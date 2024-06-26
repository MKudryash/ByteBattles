﻿using ByteBattles.DataAccess.Configurations;
using ByteBattles.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace ByteBattles.DataAccess;

public partial class ByteBattlesDbContext(DbContextOptions<ByteBattlesDbContext> options) : DbContext(options)
{

    public virtual DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new LanguageProgrammingConfiguration());
        modelBuilder.ApplyConfiguration(new TagConfiguration());
        modelBuilder.ApplyConfiguration(new TaskConfiguration());
        modelBuilder.ApplyConfiguration(new TaskTagConfiguration());
        modelBuilder.ApplyConfiguration(new CompletedTaskConfiguration());
        modelBuilder.ApplyConfiguration(new FavoriteTaskConfiguration());
        modelBuilder.ApplyConfiguration(new LpTaskConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
