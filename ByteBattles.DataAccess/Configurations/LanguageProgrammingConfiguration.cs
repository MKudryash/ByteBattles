using ByteBattles.DataAccess.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBattles.DataAccess.models;

namespace ByteBattles.DataAccess.Configurations
{
    public class LanguageProgrammingConfiguration : IEntityTypeConfiguration<LanguageProgrammingEntity>
    {
        public void Configure(EntityTypeBuilder<LanguageProgrammingEntity> builder)
        {
            builder.HasKey(e => e.IdLaguageProgramming);

            builder.Property(e => e.IdLaguageProgramming)
                .ValueGeneratedNever();
            builder.Property(e => e.Title)
                .HasMaxLength(30);
        }
    }
}
