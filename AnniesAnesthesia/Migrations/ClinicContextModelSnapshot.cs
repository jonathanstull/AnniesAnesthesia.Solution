﻿// <auto-generated />
<<<<<<< HEAD
using System;
=======
>>>>>>> 54910cc (creates Home and Patients views)
using AnniesAnesthesia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinic.Migrations
{
    [DbContext(typeof(ClinicContext))]
    partial class ClinicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnniesAnesthesia.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

<<<<<<< HEAD
                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("RealHireDate")
                        .HasColumnType("datetime(6)");
=======
                    b.Property<string>("HireDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Specialty")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");
>>>>>>> 54910cc (creates Home and Patients views)

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("AnniesAnesthesia.Models.DoctorPatient", b =>
                {
                    b.Property<int>("DoctorPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("DoctorPatientId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatient");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AnniesAnesthesia.Models.DoctorSpecialty", b =>
                {
                    b.Property<int>("DoctorSpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.HasKey("DoctorSpecialtyId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("DoctorSpecialties");
                });

=======
>>>>>>> 54910cc (creates Home and Patients views)
            modelBuilder.Entity("AnniesAnesthesia.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ailment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

<<<<<<< HEAD
                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("RealBirthDate")
                        .HasColumnType("datetime(6)");
=======
                    b.Property<string>("Birthdate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");
>>>>>>> 54910cc (creates Home and Patients views)

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AnniesAnesthesia.Models.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SpecialtyId");

                    b.ToTable("Specialties");
                });

=======
>>>>>>> 54910cc (creates Home and Patients views)
            modelBuilder.Entity("AnniesAnesthesia.Models.DoctorPatient", b =>
                {
                    b.HasOne("AnniesAnesthesia.Models.Doctor", "Doctor")
                        .WithMany("JoinEntities")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnniesAnesthesia.Models.Patient", "Patient")
                        .WithMany("JoinEntities")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AnniesAnesthesia.Models.DoctorSpecialty", b =>
                {
                    b.HasOne("AnniesAnesthesia.Models.Doctor", "Doctor")
                        .WithMany("JoinEntitiesSpecialty")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnniesAnesthesia.Models.Specialty", "Specialty")
                        .WithMany("JoinEntitiesSpecialty")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("AnniesAnesthesia.Models.Doctor", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("JoinEntitiesSpecialty");
=======
            modelBuilder.Entity("AnniesAnesthesia.Models.Doctor", b =>
                {
                    b.Navigation("JoinEntities");
>>>>>>> 54910cc (creates Home and Patients views)
                });

            modelBuilder.Entity("AnniesAnesthesia.Models.Patient", b =>
                {
                    b.Navigation("JoinEntities");
                });
<<<<<<< HEAD

            modelBuilder.Entity("AnniesAnesthesia.Models.Specialty", b =>
                {
                    b.Navigation("JoinEntitiesSpecialty");
                });
=======
>>>>>>> 54910cc (creates Home and Patients views)
#pragma warning restore 612, 618
        }
    }
}
