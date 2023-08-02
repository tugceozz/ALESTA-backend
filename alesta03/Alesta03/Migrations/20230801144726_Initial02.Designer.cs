﻿// <auto-generated />
using System;
using Alesta03.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Alesta03.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230801144726_Initial02")]
    partial class Initial02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Alesta03.Model.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AdvertDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("AdvertName")
                        .HasColumnType("text");

                    b.Property<string>("AdvertType")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("Department")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("WorkPreference")
                        .HasColumnType("text");

                    b.Property<string>("WorkType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("Alesta03.Model.AdvertApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ApproveDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("PersonId");

                    b.ToTable("AdvertApprovals");
                });

            modelBuilder.Entity("Alesta03.Model.ApprovalStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("BackWorkId")
                        .HasColumnType("integer");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("BackWorkId");

                    b.HasIndex("CompanyId");

                    b.ToTable("ApprovalStatuses");
                });

            modelBuilder.Entity("Alesta03.Model.BackEdu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<float>("Avg")
                        .HasColumnType("real");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EduStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SchoolType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("BackEdus");
                });

            modelBuilder.Entity("Alesta03.Model.BackWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("AppLetter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyMail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.ToTable("BackWorks");
                });

            modelBuilder.Entity("Alesta03.Model.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prof")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalStaff")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UsersId")
                        .HasColumnType("integer");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("UsersId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Alesta03.Model.EduStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("BackEduId")
                        .HasColumnType("integer");

                    b.Property<int?>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("BackEduId");

                    b.HasIndex("PersonId");

                    b.ToTable("EduStatuses");
                });

            modelBuilder.Entity("Alesta03.Model.ExpReview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PersonId");

                    b.ToTable("ExpReviews");
                });

            modelBuilder.Entity("Alesta03.Model.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UsersId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Alesta03.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("PostDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Alesta03.Model.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Alesta03.Model.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsFirstLogin")
                        .HasColumnType("boolean");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Alesta03.Model.WorkStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("BackWorkId")
                        .HasColumnType("integer");

                    b.Property<int?>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("BackWorkId");

                    b.HasIndex("PersonId");

                    b.ToTable("WorkStatuses");
                });

            modelBuilder.Entity("Alesta03.Model.Advert", b =>
                {
                    b.HasOne("Alesta03.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alesta03.Model.AdvertApproval", b =>
                {
                    b.HasOne("Alesta03.Model.Advert", "Advert")
                        .WithMany("AdvertApprovals")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alesta03.Model.Person", "person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("person");
                });

            modelBuilder.Entity("Alesta03.Model.ApprovalStatus", b =>
                {
                    b.HasOne("Alesta03.Model.BackWork", "BackWork")
                        .WithMany("ApprovalStatuses")
                        .HasForeignKey("BackWorkId");

                    b.HasOne("Alesta03.Model.Company", "Company")
                        .WithMany("ApprovalStatuses")
                        .HasForeignKey("CompanyId");

                    b.Navigation("BackWork");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Alesta03.Model.Company", b =>
                {
                    b.HasOne("Alesta03.Model.User", "Users")
                        .WithMany("Companies")
                        .HasForeignKey("UsersId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Alesta03.Model.EduStatus", b =>
                {
                    b.HasOne("Alesta03.Model.BackEdu", "BackEdu")
                        .WithMany("EduStatuses")
                        .HasForeignKey("BackEduId");

                    b.HasOne("Alesta03.Model.Person", "Person")
                        .WithMany("EduStatuses")
                        .HasForeignKey("PersonId");

                    b.Navigation("BackEdu");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Alesta03.Model.ExpReview", b =>
                {
                    b.HasOne("Alesta03.Model.Company", "Company")
                        .WithMany("Reviews")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Alesta03.Model.Person", "Person")
                        .WithMany("Reviews")
                        .HasForeignKey("PersonId");

                    b.Navigation("Company");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Alesta03.Model.Person", b =>
                {
                    b.HasOne("Alesta03.Model.User", "Users")
                        .WithMany("People")
                        .HasForeignKey("UsersId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Alesta03.Model.Post", b =>
                {
                    b.HasOne("Alesta03.Model.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alesta03.Model.WorkStatus", b =>
                {
                    b.HasOne("Alesta03.Model.BackWork", "BackWork")
                        .WithMany("WorkStatuses")
                        .HasForeignKey("BackWorkId");

                    b.HasOne("Alesta03.Model.Person", "Person")
                        .WithMany("WorkStatuses")
                        .HasForeignKey("PersonId");

                    b.Navigation("BackWork");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Alesta03.Model.Advert", b =>
                {
                    b.Navigation("AdvertApprovals");
                });

            modelBuilder.Entity("Alesta03.Model.BackEdu", b =>
                {
                    b.Navigation("EduStatuses");
                });

            modelBuilder.Entity("Alesta03.Model.BackWork", b =>
                {
                    b.Navigation("ApprovalStatuses");

                    b.Navigation("WorkStatuses");
                });

            modelBuilder.Entity("Alesta03.Model.Company", b =>
                {
                    b.Navigation("ApprovalStatuses");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Alesta03.Model.Person", b =>
                {
                    b.Navigation("EduStatuses");

                    b.Navigation("Reviews");

                    b.Navigation("WorkStatuses");
                });

            modelBuilder.Entity("Alesta03.Model.User", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("People");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}