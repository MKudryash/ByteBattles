using ByteBattles.DataAccess.Configurations;
using ByteBattles.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace ByteBattles.DataAccess;

public partial class ByteBattlesDbContext(DbContextOptions<ByteBattlesDbContext> options) : DbContext(options)
{

    public virtual DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
