using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Entities;

public partial class SuhrobOfficialContext : DbContext
{
    public SuhrobOfficialContext()
    {
    }

    public SuhrobOfficialContext(DbContextOptions<SuhrobOfficialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Prize> Prizes { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=192.168.109.99;Database=suhrob_official;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Prize>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasIndex(e => e.GameId, "IX_Tickets_GameId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Game).WithMany(p => p.Tickets).HasForeignKey(d => d.GameId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
