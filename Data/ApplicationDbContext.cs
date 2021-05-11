using GHC2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GHC2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Analysis> Analyses { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<DiagnosePrescription> DiagnosePrescriptions { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }
        public virtual DbSet<Radiation> Radiations { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Server=Server=DESKTOP-D2R2HM9;Database=GHC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChatUser>()
              .HasKey(x => new { x.ChatId, x.UserId });
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Nid);

                entity.ToTable("Admin");

                entity.Property(e => e.Nid)
                    .ValueGeneratedNever()
                    .HasColumnName("NID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BitrhDate).HasColumnType("datetime").IsRequired();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Analysis>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachUrl)
                    .IsRequired()
                    .HasColumnName("AttachURL");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Report).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Analyses)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analyses_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Analyses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analyses_Patient");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accepted)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("NO");

                entity.Property(e => e.AppointmetDateTime).HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_Patient");
            });



            modelBuilder.Entity<Diagnose>(entity =>
            {
                entity.ToTable("Diagnose");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiagnoseDateTime).HasColumnType("datetime");

                entity.Property(e => e.DiagnoseDescription).IsRequired();

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.RequiredAnalyses).HasMaxLength(50);

                entity.Property(e => e.RequiredRadiation).HasMaxLength(50);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diagnose_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diagnose_Patient");
            });

            modelBuilder.Entity<DiagnosePrescription>(entity =>
            {
                entity.HasKey(e => e.PrescriptionId);

                entity.ToTable("Diagnose_Prescription");

                entity.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");

                entity.Property(e => e.DiagnoseId).HasColumnName("DiagnoseID");

                entity.HasOne(d => d.Diagnose)
                    .WithMany(p => p.DiagnosePrescriptions)
                    .HasForeignKey(d => d.DiagnoseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diagnose_Prescription_Diagnose");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.Nid);

                entity.ToTable("Doctor");

                entity.HasIndex(e => e.UserName, "Unique_Username")
                    .IsUnique();

                entity.Property(e => e.Nid)
                    .ValueGeneratedNever()
                    .HasColumnName("NID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BitrhDate).HasColumnType("datetime").IsRequired();

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Specialty)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.ToTable("Medicine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Specialty)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Nid)
                    .HasName("PK_Patient_1");

                entity.ToTable("Patient");

                entity.Property(e => e.Nid)
                    .ValueGeneratedNever()
                    .HasColumnName("NID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BitrhDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PrescriptionMedicine>(entity =>
            {
                entity.HasKey(e => e.Id)
                         .HasName("PK_PrescriptionMedicine");
                entity.ToTable("Prescription_Medicine");

                entity.Property(e => e.Dose).HasMaxLength(50);

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");

                entity.HasOne(d => d.Medicine)
                    .WithMany()
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prescription_Medicine_Medicine");

                entity.HasOne(d => d.Prescription)
                    .WithMany()
                    .HasForeignKey(d => d.PrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prescription_Medicine_Diagnose_Prescription");
            });

            modelBuilder.Entity<Radiation>(entity =>
            {
                entity.ToTable("Radiation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachUrl)
                    .HasColumnName("AttachURL");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Report).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.Radiations)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Radiation_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Radiations)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Radiation_Patient");
            });

            //      OnModelCreatingPartial(modelBuilder);
        }

        //    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}