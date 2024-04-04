using System;
using System.Collections.Generic;

namespace ByteBattles.DataAccess.Entites;

public partial class UserEntity
{
    public Guid Id { get; set; }

    public string? Username { get; set; }

    public string? Encryptedpassword { get; set; }

    public string? Email { get; set; }
}
