﻿// <auto-generated />
using System;
using Medical_Diagnosis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medical_Diagnosis.Migrations
{
    [DbContext(typeof(MedicalDiagnosisContext))]
    partial class MedicalDiagnosisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Medical_Diagnosis.Models.Candidate", b =>
                {
                    b.Property<int>("CdoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Cdoctor_ID");

                    b.Property<int>("DresultId")
                        .HasColumnType("int")
                        .HasColumnName("Dresult_ID");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Doctor_ID");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("Patient_ID");

                    b.Property<string>("Purpose")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CdoctorId", "DresultId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("DresultId");

                    b.HasIndex("PatientId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.CandidateDoctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PN");

                    b.Property<string>("Specialize")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Candidate Doctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ApClosetime")
                        .HasColumnType("date")
                        .HasColumnName("AP_Closetime");

                    b.Property<DateTime>("ApOpentime")
                        .HasColumnType("date")
                        .HasColumnName("AP_Opentime");

                    b.Property<string>("Mail")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telephone")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Clinic");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("AutoDresult")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Auto_Dresult");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Doctor_ID");

                    b.Property<string>("DoctorNote")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Doctor_Note");

                    b.Property<double?>("StatDresult")
                        .HasColumnType("float")
                        .HasColumnName("Stat_Dresult");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Diagnosis Result");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Doctor_ID");

                    b.Property<int?>("GdtestId")
                        .HasColumnType("int")
                        .HasColumnName("GDtest_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Unit")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Diagnosis Test");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisTestRange", b =>
                {
                    b.Property<int>("DtestId")
                        .HasColumnType("int")
                        .HasColumnName("Dtest_ID");

                    b.Property<string>("PatientType")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Patient_Type");

                    b.Property<double?>("EndRange")
                        .HasColumnType("float")
                        .HasColumnName("End_Range");

                    b.Property<double?>("StartRange")
                        .HasColumnType("float")
                        .HasColumnName("Start_Range");

                    b.HasKey("DtestId", "PatientType");

                    b.ToTable("Diagnosis Test Range");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Disease");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseExistDresult", b =>
                {
                    b.Property<int>("DiseaseId")
                        .HasColumnType("int")
                        .HasColumnName("Disease_ID");

                    b.Property<int>("DresultId")
                        .HasColumnType("int")
                        .HasColumnName("Dresult_ID");

                    b.HasKey("DiseaseId", "DresultId");

                    b.HasIndex("DresultId");

                    b.ToTable("Disease_Exist_Dresult");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseRelateDtest", b =>
                {
                    b.Property<int>("DiseaseId")
                        .HasColumnType("int")
                        .HasColumnName("Disease_ID");

                    b.Property<int>("DtestId")
                        .HasColumnType("int")
                        .HasColumnName("Dtest_ID");

                    b.HasKey("DiseaseId", "DtestId");

                    b.HasIndex("DtestId");

                    b.ToTable("Disease_relate_Dtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseRelateGdtest", b =>
                {
                    b.Property<int>("DiseaseId")
                        .HasColumnType("int")
                        .HasColumnName("Disease_ID");

                    b.Property<int>("GdtestId")
                        .HasColumnType("int")
                        .HasColumnName("GDtest_ID");

                    b.HasKey("DiseaseId", "GdtestId");

                    b.HasIndex("GdtestId");

                    b.ToTable("Disease_relate_GDtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseSymptom", b =>
                {
                    b.Property<int>("DiseaseId")
                        .HasColumnType("int")
                        .HasColumnName("Disease_ID");

                    b.Property<string>("Symptom")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("DiseaseId", "Symptom");

                    b.ToTable("Disease Symptoms");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int?>("ClinicId")
                        .HasColumnType("int")
                        .HasColumnName("Clinic_ID");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("MedicalLicenseId")
                        .HasColumnType("int")
                        .HasColumnName("MedicalLicense_ID");

                    b.Property<string>("Pn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PN");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DoctorCrudCdoctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Doctor_ID");

                    b.Property<int>("CdoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Cdoctor_ID");

                    b.HasKey("DoctorId", "CdoctorId");

                    b.HasIndex("CdoctorId");

                    b.ToTable("Doctor_CRUD_Cdoctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DtestDresult", b =>
                {
                    b.Property<int>("DresultId")
                        .HasColumnType("int")
                        .HasColumnName("Dresult_ID");

                    b.Property<int>("DtestId")
                        .HasColumnType("int")
                        .HasColumnName("Dtest_ID");

                    b.Property<double?>("ResultValue")
                        .HasColumnType("float")
                        .HasColumnName("Result_Value");

                    b.HasKey("DresultId", "DtestId");

                    b.HasIndex("DtestId");

                    b.ToTable("Dtest_Dresult");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.GdtestDresult", b =>
                {
                    b.Property<int>("DresultId")
                        .HasColumnType("int")
                        .HasColumnName("Dresult_ID");

                    b.Property<int>("GdtestId")
                        .HasColumnType("int")
                        .HasColumnName("GDtest_ID");

                    b.HasKey("DresultId", "GdtestId");

                    b.HasIndex("GdtestId");

                    b.ToTable("GDtest_Dresult");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.GeneralDiagnosisTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Doctor_ID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("General Diagnosis Test");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Give", b =>
                {
                    b.Property<int>("DresultId")
                        .HasColumnType("int")
                        .HasColumnName("Dresult_ID");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("date")
                        .HasColumnName("Send_Date");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("Doctor_ID");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("Patient_ID");

                    b.HasKey("DresultId", "SendDate");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Give");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Greserve", b =>
                {
                    b.Property<int>("ClinicId")
                        .HasColumnType("int")
                        .HasColumnName("Clinic_ID");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("date")
                        .HasColumnName("Reservation_Date");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("date")
                        .HasColumnName("Request_Date");

                    b.Property<int?>("GdtestId")
                        .HasColumnType("int")
                        .HasColumnName("GDtest_ID");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("Patient_ID");

                    b.HasKey("ClinicId", "ReservationDate", "RequestDate");

                    b.HasIndex("GdtestId");

                    b.HasIndex("PatientId");

                    b.ToTable("GReserve");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PN");

                    b.HasKey("Id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Reserve", b =>
                {
                    b.Property<int>("ClinicId")
                        .HasColumnType("int")
                        .HasColumnName("Clinic_ID");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("date")
                        .HasColumnName("Reservation_Date");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("date")
                        .HasColumnName("Request_Date");

                    b.Property<int?>("DtestId")
                        .HasColumnType("int")
                        .HasColumnName("Dtest_ID");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("Patient_ID");

                    b.HasKey("ClinicId", "ReservationDate", "RequestDate");

                    b.HasIndex("DtestId");

                    b.HasIndex("PatientId");

                    b.ToTable("Reserve");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Candidate", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.CandidateDoctor", "Cdoctor")
                        .WithMany("Candidates")
                        .HasForeignKey("CdoctorId")
                        .HasConstraintName("FK_Candidate_Candidate Doctor")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.Doctor", "Doctor")
                        .WithMany("Candidates")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Candidate_Doctor");

                    b.HasOne("Medical_Diagnosis.Models.DiagnosisResult", "Dresult")
                        .WithMany("Candidates")
                        .HasForeignKey("DresultId")
                        .HasConstraintName("FK_Candidate_Diagnosis Result")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.Patient", "Patient")
                        .WithMany("Candidates")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_Candidate_Patient");

                    b.Navigation("Cdoctor");

                    b.Navigation("Doctor");

                    b.Navigation("Dresult");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisResult", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Doctor", "Doctor")
                        .WithMany("DiagnosisResults")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Diagnosis Result_Doctor");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisTest", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Doctor", "Doctor")
                        .WithMany("DiagnosisTests")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Diagnosis Test_Doctor");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisTestRange", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.DiagnosisTest", "Dtest")
                        .WithMany("DiagnosisTestRanges")
                        .HasForeignKey("DtestId")
                        .HasConstraintName("FK_Diagnosis Test Range_Diagnosis Test")
                        .IsRequired();

                    b.Navigation("Dtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseExistDresult", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Disease", "Disease")
                        .WithMany("DiseaseExistDresults")
                        .HasForeignKey("DiseaseId")
                        .HasConstraintName("FK_Disease_Exist_Dresult_Disease")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.DiagnosisResult", "Dresult")
                        .WithMany("DiseaseExistDresults")
                        .HasForeignKey("DresultId")
                        .HasConstraintName("FK_Disease_Exist_Dresult_Diagnosis Result")
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Dresult");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseRelateDtest", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Disease", "Disease")
                        .WithMany("DiseaseRelateDtests")
                        .HasForeignKey("DiseaseId")
                        .HasConstraintName("FK_Disease_relate_Dtest_Disease")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.DiagnosisTest", "Dtest")
                        .WithMany("DiseaseRelateDtests")
                        .HasForeignKey("DtestId")
                        .HasConstraintName("FK_Disease_relate_Dtest_Diagnosis Test")
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Dtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseRelateGdtest", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Disease", "Disease")
                        .WithMany("DiseaseRelateGdtests")
                        .HasForeignKey("DiseaseId")
                        .HasConstraintName("FK_Disease_relate_GDtest_Disease")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.GeneralDiagnosisTest", "Gdtest")
                        .WithMany("DiseaseRelateGdtests")
                        .HasForeignKey("GdtestId")
                        .HasConstraintName("FK_Disease_relate_GDtest_General Diagnosis Test")
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Gdtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiseaseSymptom", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Disease", "Disease")
                        .WithMany("DiseaseSymptoms")
                        .HasForeignKey("DiseaseId")
                        .HasConstraintName("FK_Disease Symptoms_Disease")
                        .IsRequired();

                    b.Navigation("Disease");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Doctor", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Clinic", "Clinic")
                        .WithMany("Doctors")
                        .HasForeignKey("ClinicId")
                        .HasConstraintName("FK_Doctor_Clinic");

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DoctorCrudCdoctor", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.CandidateDoctor", "Cdoctor")
                        .WithMany("DoctorCrudCdoctors")
                        .HasForeignKey("CdoctorId")
                        .HasConstraintName("FK_Doctor_CRUD_Cdoctor_Candidate Doctor")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.Doctor", "Doctor")
                        .WithMany("DoctorCrudCdoctors")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Doctor_CRUD_Cdoctor_Doctor")
                        .IsRequired();

                    b.Navigation("Cdoctor");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DtestDresult", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.DiagnosisResult", "Dresult")
                        .WithMany("DtestDresults")
                        .HasForeignKey("DresultId")
                        .HasConstraintName("FK_Dtest_Dresult_Diagnosis Result")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.DiagnosisTest", "Dtest")
                        .WithMany("DtestDresults")
                        .HasForeignKey("DtestId")
                        .HasConstraintName("FK_Dtest_Dresult_Diagnosis Test")
                        .IsRequired();

                    b.Navigation("Dresult");

                    b.Navigation("Dtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.GdtestDresult", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.DiagnosisResult", "Dresult")
                        .WithMany("GdtestDresults")
                        .HasForeignKey("DresultId")
                        .HasConstraintName("FK_GDtest_Dresult_Diagnosis Result")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.GeneralDiagnosisTest", "Gdtest")
                        .WithMany("GdtestDresults")
                        .HasForeignKey("GdtestId")
                        .HasConstraintName("FK_GDtest_Dresult_General Diagnosis Test")
                        .IsRequired();

                    b.Navigation("Dresult");

                    b.Navigation("Gdtest");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.GeneralDiagnosisTest", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Doctor", "Doctor")
                        .WithMany("GeneralDiagnosisTests")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_General Diagnosis Test_Doctor");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Give", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Doctor", "Doctor")
                        .WithMany("Gives")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK_Give_Doctor");

                    b.HasOne("Medical_Diagnosis.Models.DiagnosisResult", "Dresult")
                        .WithMany("Gives")
                        .HasForeignKey("DresultId")
                        .HasConstraintName("FK_Give_Diagnosis Result")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.Patient", "Patient")
                        .WithMany("Gives")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_Give_Patient");

                    b.Navigation("Doctor");

                    b.Navigation("Dresult");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Greserve", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Clinic", "Clinic")
                        .WithMany("Greserves")
                        .HasForeignKey("ClinicId")
                        .HasConstraintName("FK_GReserve_Clinic")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.GeneralDiagnosisTest", "Gdtest")
                        .WithMany("Greserves")
                        .HasForeignKey("GdtestId")
                        .HasConstraintName("FK_GReserve_General Diagnosis Test");

                    b.HasOne("Medical_Diagnosis.Models.Patient", "Patient")
                        .WithMany("Greserves")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_GReserve_Patient");

                    b.Navigation("Clinic");

                    b.Navigation("Gdtest");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Reserve", b =>
                {
                    b.HasOne("Medical_Diagnosis.Models.Clinic", "Clinic")
                        .WithMany("Reserves")
                        .HasForeignKey("ClinicId")
                        .HasConstraintName("FK_Reserve_Clinic")
                        .IsRequired();

                    b.HasOne("Medical_Diagnosis.Models.DiagnosisResult", "Dtest")
                        .WithMany("Reserves")
                        .HasForeignKey("DtestId")
                        .HasConstraintName("FK_Reserve_Diagnosis Result");

                    b.HasOne("Medical_Diagnosis.Models.Patient", "Patient")
                        .WithMany("Reserves")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("FK_Reserve_Patient");

                    b.Navigation("Clinic");

                    b.Navigation("Dtest");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.CandidateDoctor", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("DoctorCrudCdoctors");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Clinic", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Greserves");

                    b.Navigation("Reserves");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisResult", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("DiseaseExistDresults");

                    b.Navigation("DtestDresults");

                    b.Navigation("GdtestDresults");

                    b.Navigation("Gives");

                    b.Navigation("Reserves");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.DiagnosisTest", b =>
                {
                    b.Navigation("DiagnosisTestRanges");

                    b.Navigation("DiseaseRelateDtests");

                    b.Navigation("DtestDresults");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Disease", b =>
                {
                    b.Navigation("DiseaseExistDresults");

                    b.Navigation("DiseaseRelateDtests");

                    b.Navigation("DiseaseRelateGdtests");

                    b.Navigation("DiseaseSymptoms");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Doctor", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("DiagnosisResults");

                    b.Navigation("DiagnosisTests");

                    b.Navigation("DoctorCrudCdoctors");

                    b.Navigation("GeneralDiagnosisTests");

                    b.Navigation("Gives");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.GeneralDiagnosisTest", b =>
                {
                    b.Navigation("DiseaseRelateGdtests");

                    b.Navigation("GdtestDresults");

                    b.Navigation("Greserves");
                });

            modelBuilder.Entity("Medical_Diagnosis.Models.Patient", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Gives");

                    b.Navigation("Greserves");

                    b.Navigation("Reserves");
                });
#pragma warning restore 612, 618
        }
    }
}
