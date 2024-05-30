using ByteBattles.DataAccess.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBattles.DataAccess.Configurations
{
    public class LpTaskConfiguration : IEntityTypeConfiguration<LpTaskEntity>
    {
        public void Configure(EntityTypeBuilder<LpTaskEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedNever();
            builder.Property(e => e.IdLaguageProgramming);
            builder.Property(e => e.IdTask);
           

            builder.HasOne(d => d.IdLaguageProgrammingNavigation).WithMany(p => p.LpTasks)
                .HasForeignKey(d => d.IdLaguageProgramming);

            builder.HasOne(d => d.IdTaskNavigation).WithMany(p => p.LpTasks)
                .HasForeignKey(d => d.IdTask);
        }
    }
}
