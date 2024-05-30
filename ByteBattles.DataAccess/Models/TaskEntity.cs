using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;


[Table ("task")]
public partial class TaskEntity
{
    [Column ("id_task")]
    public int IdTask { get; set; }

    [Column ("title")]
    public string? Title { get; set; }

    [Column ("description")]
    public string? Description { get; set; }

    [Column ("complexity")]
    public int? Complexity { get; set; }

    [Column ("author")]
    public string? Author { get; set; }

    public virtual ICollection<CompletedTaskEntity> CompletedTasks { get; set; } = new List<CompletedTaskEntity>();

    public virtual ICollection<FavoriteTaskEntity> FavoriteTasks { get; set; } = new List<FavoriteTaskEntity>();

    public virtual ICollection<LpTaskEntity> LpTasks { get; set; } = new List<LpTaskEntity>();

    public virtual ICollection<TaskTagEntity> TaskTags { get; set; } = new List<TaskTagEntity>();
}
