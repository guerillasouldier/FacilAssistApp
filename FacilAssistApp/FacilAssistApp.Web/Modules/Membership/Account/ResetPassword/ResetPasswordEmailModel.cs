namespace FacilAssistApp.Modules.Membership.Account.ResetPassword
{
    public class ResetPasswordEmailModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string ResetLink { get; set; }
    }
}