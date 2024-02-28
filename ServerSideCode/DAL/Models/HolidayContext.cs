using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class HolidayContext : DbContext
{
    public HolidayContext(DbContextOptions<HolidayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<HolidayCottage> HolidayCottages { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__A25C5AA63A47A437");

            entity.ToTable("Address");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.RegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Regions");

            entity.HasOne(d => d.TownCodeNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.TownCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Towns");
        });

        modelBuilder.Entity<HolidayCottage>(entity =>
        {
            entity.HasKey(e => e.CottageName).HasName("PK__HolidayC__9FD258026A2309B3");

            entity.Property(e => e.CottageName).HasMaxLength(50);

            entity.HasOne(d => d.AddressCodeNavigation).WithMany(p => p.HolidayCottages)
                .HasForeignKey(d => d.AddressCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayCottages_Address");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Regions__A25C5AA68DCCB6DF");

            entity.Property(e => e.Rgion)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Towns__A25C5AA625F2856D");

            entity.Property(e => e.Town1)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Town");

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.Towns)
                .HasForeignKey(d => d.RegionCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Town_Regions");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
