using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBattles.DataAccess.models;

[Table("laguage_programming")]
public partial class LanguageProgrammingEntity
{

    [Column ("id_language_programming")]
    public int IdLaguageProgramming { get; set; }

    [Column ("title")]
    public string? Title { get; set; }

    public virtual ICollection<LpTaskEntity> LpTasks { get; set; } = new List<LpTaskEntity>();
}
