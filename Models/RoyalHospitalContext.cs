using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RoyalHospital.Models
{
    public partial class RoyalHospitalContext : DbContext
    {
        public RoyalHospitalContext()
        {
        }

        public RoyalHospitalContext(DbContextOptions<RoyalHospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinic> Clinics { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<News> News { get; set; } = null!;
        public virtual DbSet<SlideItem> SlideItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RoyalHospital;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.ToTable("Clinic");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ImgHome)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");

                entity.Property(e => e.Img)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Schedule)
                    .HasMaxLength(185)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.ClinicId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Doctor_Clinic");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ImgHome)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Selector)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SlideItem>(entity =>
            {
                entity.ToTable("SlideItem");

                entity.Property(e => e.Img)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.YoutubeLink)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
