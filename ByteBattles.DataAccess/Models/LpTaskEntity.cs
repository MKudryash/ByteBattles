using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;

[Table ("lp_task")]
public partial class LpTaskEntity
{
    [Column ("id")]
    public int Id { get; set; }

    [Column ("id_langugage_programming")]
    public int? IdLaguageProgramming { get; set; }

    [Column ("id_task")]
    public int? IdTask { get; set; }

    public virtual LanguageProgrammingEntity? IdLaguageProgrammingNavigation { get; set; }

    public virtual TaskEntity? IdTaskNavigation { get; set; }
}
