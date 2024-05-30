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
    public class TagConfiguration : IEntityTypeConfiguration<TagEntity>
    {
        public void Configure(EntityTypeBuilder<TagEntity> builder)
        {

            builder.HasKey(e => e.IdTag);

            builder.Property(e => e.IdTag)
                .ValueGeneratedNever();
            builder.Property(e => e.Tag)
                .HasMaxLength(30);

        }
    }
}
