using ByteBattles.Apllication.Interfaces.Auth;
using ByteBattles.Application.Interfaces.Auth;
using ByteBattles.Core.Interfaces.Repositories;
using ByteBattles.Core.Interfaces.Services;
using ByteBattles.Core.Models;

namespace ByteBattles.Application.Services
{
    public class UsersServices : IUsersServices
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public UsersServices(IPasswordHasher passwordHasher, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            this._passwordHasher = passwordHasher;
            this._userRepository = userRepository;
            this._jwtProvider = jwtProvider;
        }

        public async Task SignUp(string userName, string email, string password)
        {
            var encryptedPassword = _passwordHasher.Generate(password);

            var user = User.Create(Guid.NewGuid(), userName, encryptedPassword, email);
            await _userRepository.Add(user);
        }
        public async Task<string> SignIn(string email, string password)
        {
            var user = await _userRepository.GetByEmail(email);

            var result = _passwordHasher.Verify(password, user.EncryptedPassword);
            if (!result)
            {
                throw new Exception("Failed to login");
            }
            var token = _jwtProvider.Generate(user);

            return token;
        }
    }
}
