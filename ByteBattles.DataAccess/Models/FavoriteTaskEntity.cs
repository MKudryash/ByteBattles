using ByteBattles.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;


[Table("favorite_task")]
public partial class FavoriteTaskEntity
{
    [Column ("id")]
    public int Id { get; set; }

    [Column ("id_task")]
    public int? IdTask { get; set; }

    [Column ("id_user")]
    public Guid? IdUser { get; set; }

    public virtual TaskEntity? IdTaskNavigation { get; set; }

    public virtual UserEntity? IdUserNavigation { get; set; }
}
