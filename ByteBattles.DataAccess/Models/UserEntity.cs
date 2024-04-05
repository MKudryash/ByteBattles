using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.Entites;
[Table("users")]
public partial class UserEntity
{
    [Column ("id")]
    public Guid Id { get; set; }

    [Column ("username")]
    public string? Username { get; set; }

    [Column ("encryptedpassword")]
    public string? Encryptedpassword { get; set; }

    [Column ("email")]
    public string? Email { get; set; }
}
