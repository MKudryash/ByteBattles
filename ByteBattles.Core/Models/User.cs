
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.Core.Models
{
    
    public class User
    {

        public User(Guid id, string userName, string encryptedPassword, string email)
        {
            Id = id;
            UserName = userName;
            EncryptedPassword = encryptedPassword;
            Email = email;
        }

        public Guid Id { get; set; }
        public string UserName { get; private set; }
        public string EncryptedPassword { get; private set; }
        public string Email { get; private set; }


        public static User Create(Guid id, string userName, string encryptedPassword, string email)
        {
            return new User(id, userName, encryptedPassword, email);
        }
    }
}
