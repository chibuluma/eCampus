using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace eCampus.DAL.Models
{
    public partial class eCampusContext : IdentityDbContext
    {
        public eCampusContext()
        {
        }

        public eCampusContext(DbContextOptions<eCampusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=eCampus;User Id=sa;Password='MVemjsunp1;';");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CourseDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Programme)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ProgrammeId)
                    .HasConstraintName("Course_FK");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId)
                    .IsRequired()
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Programme)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ProgrammeId)
                    .HasConstraintName("Departments_FK");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("District_FK");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("District_FK_1");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("Institution");

                entity.Property(e => e.InstitutionId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictId)
                    .IsRequired()
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId)
                    .IsRequired()
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Institution_FK_1");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("Institution_FK");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("Institution_FK_2");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable("Lecturer");

                entity.Property(e => e.LecturerId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NRC");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Lecturers)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("Lecturer_FK_2");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Lecturers)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("Lecturer_FK");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Lecturers)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("Lecturer_FK_1");
            });

            modelBuilder.Entity<Programme>(entity =>
            {
                entity.ToTable("Programme");

                entity.Property(e => e.ProgrammeId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProgrammeDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Programmes)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Programme_FK");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("Province_FK");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("School");

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Schools)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("School_FK");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NRC");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Students_FK");
            });

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
