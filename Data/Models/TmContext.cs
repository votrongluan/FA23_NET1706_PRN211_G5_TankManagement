using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

public partial class TmContext : DbContext
{
    public TmContext()
    {
    }

    public TmContext(DbContextOptions<TmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ammo> Ammos { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Manufactory> Manufactories { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Tank> Tanks { get; set; }

    public virtual DbSet<TankDriver> TankDrivers { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnitManager> UnitManagers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= TM;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ammo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ammo__3213E83F0A2D7857");

            entity.ToTable("Ammo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Driver__3213E83F44E5E324");

            entity.ToTable("Driver");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCard)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idCard");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .HasColumnName("phone");
            entity.Property(e => e.UnitId).HasColumnName("unitId");

            entity.HasOne(d => d.Unit).WithMany(p => p.Drivers)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("Driver_fk0");
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__History__3213E83F03DEAC84");

            entity.ToTable("History");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.FromUnitId).HasColumnName("fromUnitId");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.TankId).HasColumnName("tankId");
            entity.Property(e => e.ToUnitId).HasColumnName("toUnitId");

            entity.HasOne(d => d.FromUnit).WithMany(p => p.HistoryFromUnits)
                .HasForeignKey(d => d.FromUnitId)
                .HasConstraintName("History_fk0");

            entity.HasOne(d => d.Tank).WithMany(p => p.Histories)
                .HasForeignKey(d => d.TankId)
                .HasConstraintName("History_fk2");

            entity.HasOne(d => d.ToUnit).WithMany(p => p.HistoryToUnits)
                .HasForeignKey(d => d.ToUnitId)
                .HasConstraintName("History_fk1");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3213E83FA8076281");

            entity.ToTable("Location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Manufactory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manufact__3213E83FABC29DC6");

            entity.ToTable("Manufactory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.LocationId).HasColumnName("locationId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.Location).WithMany(p => p.Manufactories)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("Manufactory_fk0");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Model__3213E83F9FDF8CE1");

            entity.ToTable("Model");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AmmoId).HasColumnName("ammoId");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .HasColumnName("detail");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.MaxNoDriver).HasColumnName("maxNoDriver");
            entity.Property(e => e.MaxSpeed).HasColumnName("maxSpeed");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ShootingRange).HasColumnName("shootingRange");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Ammo).WithMany(p => p.Models)
                .HasForeignKey(d => d.AmmoId)
                .HasConstraintName("Model_fk0");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3213E83F107FD426");

            entity.ToTable("Role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("description");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
        });

        modelBuilder.Entity<Tank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tank__3213E83F15A9BC99");

            entity.ToTable("Tank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.ManufactoryId).HasColumnName("manufactoryId");
            entity.Property(e => e.ModelId).HasColumnName("modelId");
            entity.Property(e => e.UnitId).HasColumnName("unitId");

            entity.HasOne(d => d.Manufactory).WithMany(p => p.Tanks)
                .HasForeignKey(d => d.ManufactoryId)
                .HasConstraintName("Tank_fk1");

            entity.HasOne(d => d.Model).WithMany(p => p.Tanks)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("Tank_fk0");

            entity.HasOne(d => d.Unit).WithMany(p => p.Tanks)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("Tank_fk2");
        });

        modelBuilder.Entity<TankDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TankDriv__3213E83F179C3AC9");

            entity.ToTable("TankDriver");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DriverId).HasColumnName("driverId");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.TankId).HasColumnName("tankId");

            entity.HasOne(d => d.Driver).WithMany(p => p.TankDrivers)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("TankDriver_fk1");

            entity.HasOne(d => d.Tank).WithMany(p => p.TankDrivers)
                .HasForeignKey(d => d.TankId)
                .HasConstraintName("TankDriver_fk0");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Unit__3213E83FAE24ECF0");

            entity.ToTable("Unit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<UnitManager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitMana__3213E83FAD7B248C");

            entity.ToTable("UnitManager");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Unit).WithMany(p => p.UnitManagers)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("UnitManager_fk1");

            entity.HasOne(d => d.User).WithMany(p => p.UnitManagers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("UnitManager_fk0");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83FD6D9F9AD");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("User_fk0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
