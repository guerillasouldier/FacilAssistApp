﻿
using System;
using System.Web.Mvc;
using FacilAssistApp.Modules.Administration.User;
using MVC;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web.Providers;

namespace FacilAssistApp.Modules.Membership.Account.ChangePassword
{
    public partial class AccountController : Controller
    {
        [HttpGet, Authorize]
        public ActionResult ChangePassword()
        {
            return View(Views.Membership.Account.ChangePassword.AccountChangePassword);
        }

        [HttpPost, JsonFilter, ServiceAuthorize]
        public Result<ServiceResponse> ChangePassword(ChangePasswordRequest request)
        {
            return this.InTransaction("Default", uow =>
            {
                request.CheckNotNull();

                if (string.IsNullOrEmpty(request.OldPassword))
                    throw new ArgumentNullException("oldPassword");

                var username = Authorization.Username;

                if (!Dependency.Resolve<IAuthenticationService>().Validate(ref username, request.OldPassword))
                    throw new ValidationError("CurrentPasswordMismatch", Texts.Validation.CurrentPasswordMismatch);

                if (request.ConfirmPassword != request.NewPassword)
                    throw new ValidationError("PasswordConfirmMismatch", LocalText.Get("Validation.PasswordConfirm"));

                request.NewPassword = UserRepository.ValidatePassword(username, request.NewPassword, false);

                var salt = System.Web.Security.Membership.GeneratePassword(5, 1);
                var hash = SiteMembershipProvider.ComputeSHA512(request.NewPassword + salt);

                uow.Connection.UpdateById(new UserRow
                {
                    UserId = int.Parse(Authorization.UserId),
                    PasswordSalt = salt,
                    PasswordHash = hash
                });

                BatchGenerationUpdater.OnCommit(uow, UserRow.Fields.GenerationKey);

                return new ServiceResponse();
            });
        }
    }
}