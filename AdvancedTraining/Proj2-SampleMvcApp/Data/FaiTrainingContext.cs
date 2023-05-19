using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleMvcApp.Data;

public partial class FaiTrainingContext : DbContext
{
    public FaiTrainingContext()
    {
    }

    public FaiTrainingContext(DbContextOptions<FaiTrainingContext> options)
        : base(options)
    {
    }




    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblDept> TblDepts { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=FaiTraining; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__tblCity__F2D21B76A4C4D619");

            entity.ToTable("tblCity");

            entity.HasIndex(e => e.CityName, "UQ__tblCity__886159E5EFD7ED9F").IsUnique();

            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

       
        modelBuilder.Entity<TblDept>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__tblDept__014881AE1C07E5A2");

            entity.ToTable("tblDept");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__tblEmplo__AF2DBB99E88113B7");

            entity.ToTable("tblEmployee");

            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpSalary).HasColumnType("money");

            entity.HasOne(d => d.City).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__tblEmploy__CityI__49C3F6B7");

            entity.HasOne(d => d.Dept).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK__tblEmploy__DeptI__34C8D9D1");
        });

      
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
