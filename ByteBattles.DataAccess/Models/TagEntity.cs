using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;


[Table ("tag")]
public partial class TagEntity
{
    [Column ("id_tag")]
    public int IdTag { get; set; }

    [Column ("tag")]
    public string? Tag { get; set; }

    public virtual ICollection<TaskTagEntity> TaskTags { get; set; } = new List<TaskTagEntity>();
}
