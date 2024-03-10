using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALModels;

public partial class CottagesContext : DbContext
{
    public CottagesContext()
    {
    }

    public CottagesContext(DbContextOptions<CottagesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cottage> Cottages { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\FullStack_project-2024\\DB\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cottage>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Cottages__A25C5AA65D8CFD08");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.CottageName)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.Cottages)
                .HasForeignKey(d => d.RegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cottages_Regions");

            entity.HasOne(d => d.TownCodeNavigation).WithMany(p => p.Cottages)
                .HasForeignKey(d => d.TownCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cottages_Towns");
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Pictures__A25C5AA600CC4843");

            entity.Property(e => e.PicturesPath)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.CottageCodeNavigation).WithMany(p => p.Pictures)
                .HasForeignKey(d => d.CottageCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pictures_Cottages");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Regions__A25C5AA68DCCB6DF");

            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Towns__A25C5AA625F2856D");

            entity.Property(e => e.TownName)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.Towns)
                .HasForeignKey(d => d.RegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Towns_Regions");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
