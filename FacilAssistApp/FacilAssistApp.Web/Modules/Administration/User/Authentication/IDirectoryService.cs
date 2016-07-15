
namespace FacilAssistApp.Modules.Administration.User.Authentication
{
    public interface IDirectoryService
    {
        DirectoryEntry Validate(string username, string password);
    }
}