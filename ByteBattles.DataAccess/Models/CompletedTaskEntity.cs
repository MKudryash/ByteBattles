using ByteBattles.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;

[Table("completed_task")]
public partial class CompletedTaskEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("id_task")]
    public int? IdTask { get; set; }

    [Column("id_user")]
    public Guid? IdUser { get; set; }

    [Column("start_date")]
    public DateTime? StartDate { get; set; }

    [Column("end_date")]
    public DateTime? EndDate { get; set; }

    [Column("mumber_of_attempts")]
    public int? NumberOfAttempts { get; set; }


    public virtual TaskEntity? IdTaskNavigation { get; set; }

    public virtual UserEntity? IdUserNavigation { get; set; }
}
