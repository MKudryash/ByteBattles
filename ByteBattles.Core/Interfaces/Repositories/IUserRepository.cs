using ByteBattles.Core.Models;

namespace  ByteBattles.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task<User> GetByEmail(string email);
    }
}