using System;
using System.Collections.Generic;
using ByteBattles.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ByteBattles.DataAccess;

public partial class ByteBattlesDbContext : DbContext
{

    public ByteBattlesDbContext(DbContextOptions<ByteBattlesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserEntites> Users { get; set; }
    private readonly IConfiguration _configuration;
    public ByteBattlesDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 => optionsBuilder.UseNpgsql(_configuration.GetConnectionString("ConnectionStrings:ByteBattlesDB"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntites>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Encryptedpassword)
                .HasColumnType("character varying")
                .HasColumnName("encryptedpassword");
            entity.Property(e => e.Username)
                .HasMaxLength(25)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
