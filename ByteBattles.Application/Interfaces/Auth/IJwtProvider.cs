using ByteBattles.Core.Models;

namespace ByteBattlesAPI.Infrastructure.Authentication
{
    public interface IJwtProvider
    {
        string Generate(User user);
    }
}