using ByteBattles.Application.Interfaces.Auth;
using ByteBattles.Core.Interfaces.Repositories;
using ByteBattles.Core.Models;

namespace ByteBattles.Application.Services
{
    public class UsersServices
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUserRepository _userRepository;



        public UsersServices(IPasswordHasher passwordHasher, IUserRepository userRepository)
        {
            this._passwordHasher = passwordHasher;
            this._userRepository = userRepository;
        }

        public async Task SignUp(string userName, string email, string password)
        {
            var encryptedPassword = _passwordHasher.Generate(password);

            var user = User.Create(Guid.NewGuid(), userName, encryptedPassword, email);
            await _userRepository.Add(user);
        }
    }
}
