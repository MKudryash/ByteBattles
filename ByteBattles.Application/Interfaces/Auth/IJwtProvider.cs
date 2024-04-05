using ByteBattles.Core.Models;

namespace ByteBattles.Apllication.Interfaces.Auth
{
    public interface IJwtProvider
    {
        string Generate(User user);
    }
}