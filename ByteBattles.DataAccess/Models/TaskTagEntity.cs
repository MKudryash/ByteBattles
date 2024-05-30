using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;


[Table ("task_tag")]
public partial class TaskTagEntity
{
    [Column ("id")]
    public int Id { get; set; }

    [Column ("id_task")]
    public int? IdTask { get; set; }

    [Column ("id_tag")]
    public int? IdTag { get; set; }

    public virtual TagEntity? IdTagNavigation { get; set; }

    public virtual TaskEntity? IdTaskNavigation { get; set; }
}
