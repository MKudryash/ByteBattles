using ByteBattles.DataAccess.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.Entites;
[Table("users")]
public partial class UserEntity
{
    [Column ("id_user")]
    public Guid Id { get; set; }

    [Column ("username")]
    public string? Username { get; set; }

    [Column ("encryptedpassword")]
    public string? Encryptedpassword { get; set; }

    [Column ("email")]
    public string? Email { get; set; }

    public virtual ICollection<FavoriteTaskEntity> FavoriteTasks { get; set; } = new List<FavoriteTaskEntity>();
    public virtual ICollection<CompletedTaskEntity> CompletedTasks { get; set; } = new List<CompletedTaskEntity>();

}
