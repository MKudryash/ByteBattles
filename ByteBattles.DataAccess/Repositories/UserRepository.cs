using AutoMapper;
using ByteBattles.Core.Models;
using ByteBattles.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBattles.DataAccess.Repositories
{
    public class UserRepository
    {
        private readonly ByteBattlesDbContext _context;
        private readonly IMapper _mapper;


        public UserRepository(ByteBattlesDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task Add(User user)
        {
            var userEntity = new UserEntity() {
                Id = user.Id,
                Email = user.Email,
                Encryptedpassword = user.EncryptedPassword,
                Username = user.UserName,
            };
            await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
            var userEntity = await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == email) ?? throw new Exception();
            return _mapper.Map<User>(userEntity);
        }
    }
}
