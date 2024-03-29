﻿
using System;
using System.IO;
using System.Web.Mvc;
using System.Web.Security;
using FacilAssistApp.Modules.Administration.User;
using MVC;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web.Providers;

namespace FacilAssistApp.Modules.Membership.Account.ResetPassword
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult ResetPassword(string t)
        {
            int userId;
            try
            {
                using (var ms = new MemoryStream(MachineKey.Unprotect(Convert.FromBase64String(t), "ResetPassword")))
                using (var br = new BinaryReader(ms))
                {
                    var dt = DateTime.FromBinary(br.ReadInt64());
                    if (dt < DateTime.UtcNow)
                        return Content(Texts.Validation.InvalidResetToken);

                    userId = br.ReadInt32();
                }
            }
            catch (Exception)
            {
                return Content(Texts.Validation.InvalidResetToken);
            }

            using (var connection = SqlConnections.NewFor<UserRow>())
            {
                var user = connection.TryById<UserRow>(userId);
                if (user == null)
                    return Content(Texts.Validation.InvalidResetToken);
            }

            return View(Views.Membership.Account.ResetPassword.AccountResetPassword,
                new ResetPasswordModel { Token = t });
        }

        [HttpPost, JsonFilter]
        public Result<ServiceResponse> ResetPassword(ResetPasswordRequest request)
        {
            return this.InTransaction("Default", uow =>
            {
                request.CheckNotNull();

                if (string.IsNullOrEmpty(request.Token))
                    throw new ArgumentNullException("token");

                int userId;
                using (var ms = new MemoryStream(MachineKey.Unprotect(
                    Convert.FromBase64String(request.Token), "ResetPassword")))
                using (var br = new BinaryReader(ms))
                {
                    var dt = DateTime.FromBinary(br.ReadInt64());
                    if (dt < DateTime.UtcNow)
                        throw new ValidationError(Texts.Validation.InvalidResetToken);

                    userId = br.ReadInt32();
                }

                UserRow user;
                using (var connection = SqlConnections.NewFor<UserRow>())
                {
                    user = connection.TryById<UserRow>(userId);
                    if (user == null)
                        throw new ValidationError(Texts.Validation.InvalidResetToken);
                }

                if (request.ConfirmPassword != request.NewPassword)
                    throw new ValidationError("PasswordConfirmMismatch", LocalText.Get("Validation.PasswordConfirm"));

                request.NewPassword = UserRepository.ValidatePassword(user.Username, request.NewPassword, false);

                var salt = System.Web.Security.Membership.GeneratePassword(5, 1);
                var hash = SiteMembershipProvider.ComputeSHA512(request.NewPassword + salt);

                uow.Connection.UpdateById(new UserRow
                {
                    UserId = user.UserId.Value,
                    PasswordSalt = salt,
                    PasswordHash = hash
                });

                BatchGenerationUpdater.OnCommit(uow, UserRow.Fields.GenerationKey);

                return new ServiceResponse();
            });
        }
    }
}