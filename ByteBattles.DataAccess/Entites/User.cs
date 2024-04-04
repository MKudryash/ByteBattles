using System;
using System.Collections.Generic;

namespace ByteBattles.DataAccess.Entites;

public partial class User
{
    public Guid Id { get; set; }

    public string? Username { get; set; }

    public string? Encryptedpassword { get; set; }

    public string? Enail { get; set; }
}
