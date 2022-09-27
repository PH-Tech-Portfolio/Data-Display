using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CovidDataDisplay.Models;

public partial class CovidCasesAlbertaDbContext : DbContext
{
    public CovidCasesAlbertaDbContext()
    {
    }

    public CovidCasesAlbertaDbContext(DbContextOptions<CovidCasesAlbertaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Covid19AlbertaStatisticsDatum> Covid19AlbertaStatisticsData { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1434;Database=CovidCasesAlbertaDb;User Id=sa;Password=P@ssword!;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Covid19AlbertaStatisticsDatum>(entity =>
        {
            entity.ToTable("covid-19-alberta-statistics-data");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnOrder(0)
                .HasColumnName("ID");
            entity.Property(e => e.AgeGroup)
                .HasMaxLength(50)
                .HasColumnOrder(4)
                .HasColumnName("Age_group");
            entity.Property(e => e.AlbertaHealthServicesZone)
                .HasMaxLength(50)
                .HasColumnOrder(2)
                .HasColumnName("Alberta_Health_Services_Zone");
            entity.Property(e => e.CaseType)
                .HasMaxLength(50)
                .HasColumnOrder(6)
                .HasColumnName("Case_type");
            entity.Property(e => e.DateReported)
                .HasColumnOrder(1)
                .HasColumnType("date")
                .HasColumnName("Date_reported");
            entity.Property(e => e.DeathStatus)
                .HasMaxLength(50)
                .HasColumnOrder(5)
                .HasColumnName("Death_status");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnOrder(3);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
