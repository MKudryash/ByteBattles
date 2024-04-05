
namespace ByteBattles.Core.Interfaces.Services
{
    public interface IUsersServices
    {
        Task<string> SignIn(string email, string password);
        Task SignUp(string userName, string email, string password);
    }
}