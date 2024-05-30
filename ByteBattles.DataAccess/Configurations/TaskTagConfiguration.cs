using ByteBattles.DataAccess.Entites;
using ByteBattles.DataAccess.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ByteBattles.DataAccess.Configurations
{
    public class TaskTagConfiguration : IEntityTypeConfiguration<TaskTagEntity>
    {
        public void Configure(EntityTypeBuilder<TaskTagEntity> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedNever();
            builder.Property(e => e.IdTag);
            builder.Property(e => e.IdTask);

            builder.HasOne(d => d.IdTagNavigation).WithMany(p => p.TaskTags)
                        .HasForeignKey(d => d.IdTag);

            builder.HasOne(d => d.IdTaskNavigation).WithMany(p => p.TaskTags)
                        .HasForeignKey(d => d.IdTask);
            
        }
            
    }
}
