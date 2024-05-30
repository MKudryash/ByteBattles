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
    public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.HasKey(e => e.IdTask);

            builder.Property(e => e.IdTask)
                .ValueGeneratedNever();
            builder.Property(e => e.Description);
            builder.Property(e => e.Title)
                .HasMaxLength(50);
            builder.Property(e => e.Complexity);
            builder.Property(e => e.Author)
                .HasMaxLength(40);
        }
    }
}
