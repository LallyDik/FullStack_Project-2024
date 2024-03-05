using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALModels;

public partial class HolidayContext : DbContext
{
    public HolidayContext(DbContextOptions<HolidayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<HolidayCottage> HolidayCottages { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\FullStack_project-2024\\DB\\DataBase.mdf;Integrated Security=True;Connect Timeout=30");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Addresse__A25C5AA6C7FCB86F");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.RegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Addresses_Regions");

            entity.HasOne(d => d.TownCodeNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.TownCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Addresses_Towns");
        });

        modelBuilder.Entity<HolidayCottage>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__A25C5AA68D52B3B1");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.CottageName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("text");

            entity.HasOne(d => d.AddressCodeNavigation).WithMany(p => p.HolidayCottages)
                .HasForeignKey(d => d.AddressCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayCottages_Addresses");
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.HasKey(e => e.PictureCode).HasName("PK__Pictures__98EA3730C3BBCD47");

            entity.Property(e => e.PictureCode).ValueGeneratedNever();
            entity.Property(e => e.PicturePath)
                .IsRequired()
                .HasColumnType("text");

            entity.HasOne(d => d.CottgeCodeNavigation).WithMany(p => p.Pictures)
                .HasForeignKey(d => d.CottgeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Picures_Cottages");
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
                .HasConstraintName("FK_Town_Regions");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
