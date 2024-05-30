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
    public class CompletedTaskConfiguration : IEntityTypeConfiguration<CompletedTaskEntity>
    {
        public void Configure(EntityTypeBuilder<CompletedTaskEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedNever();
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.IdTask);
            builder.Property(e => e.NumberOfAttempts);
            builder.Property(e => e.IdUser)
                .HasMaxLength(25);


            builder.HasOne(d => d.IdTaskNavigation).WithMany(p => p.CompletedTasks)
                .HasForeignKey(d => d.IdTask);

            builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.CompletedTasks)
                .HasForeignKey(d => d.IdUser);
        }
    }
}
