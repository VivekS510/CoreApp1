using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreApp1.Models;

public partial class UserAppContext : DbContext
{
    public UserAppContext()
    {
    }

    public UserAppContext(DbContextOptions<UserAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserRegister> UserRegisters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Register");

            entity.ToTable("UserRegister");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastLoggedOn).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
