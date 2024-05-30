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
    public class FavoriteTaskConfiguration : IEntityTypeConfiguration<FavoriteTaskEntity>
    {
        public void Configure(EntityTypeBuilder<FavoriteTaskEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedNever();
            builder.Property(e => e.IdTask);
            builder.Property(e => e.IdUser);


            builder.HasOne(d => d.IdTaskNavigation).WithMany(p => p.FavoriteTasks)
                .HasForeignKey(d => d.IdTask);

            builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.FavoriteTasks)
                .HasForeignKey(d => d.IdUser);
        }
    }
}
