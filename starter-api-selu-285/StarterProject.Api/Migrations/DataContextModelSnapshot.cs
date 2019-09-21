﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterProject.Api.Data;

namespace StarterProject.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarterProject.Api.Features.Users.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassDescription");

                    b.Property<string>("ClassName");

                    b.Property<int>("CreditHours");

                    b.Property<string>("Prerequisite");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.ClassConcentration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId");

                    b.Property<int>("ConcentrationId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ConcentrationId");

                    b.ToTable("ClassesConcentrations");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.Concentration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcentrationName");

                    b.Property<int>("MajorId");

                    b.HasKey("Id");

                    b.HasIndex("MajorId");

                    b.ToTable("Concentrations");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MajornName");

                    b.HasKey("Id");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<float>("GPA");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            FirstName = "Seeded-Admin-FirstName",
                            GPA = 0f,
                            LastName = "Seeded-Admin-LastName",
                            PasswordHash = new byte[] { 108, 64, 180, 106, 134, 131, 51, 116, 25, 65, 87, 109, 86, 251, 228, 17, 174, 88, 201, 132 },
                            PasswordSalt = new byte[] { 40, 148, 89, 112, 27, 189, 149, 25, 223, 105, 200, 2, 137, 71, 212, 41 },
                            Role = "Admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.UserClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ClassCompleted");

                    b.Property<int>("ClassId");

                    b.Property<int>("Grade");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersClasses");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.ClassConcentration", b =>
                {
                    b.HasOne("StarterProject.Api.Features.Users.Class", "Class")
                        .WithMany("ClassesConcentrations")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StarterProject.Api.Features.Users.Concentration", "Concentration")
                        .WithMany("ClassesConcentrations")
                        .HasForeignKey("ConcentrationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.Concentration", b =>
                {
                    b.HasOne("StarterProject.Api.Features.Users.Major", "Major")
                        .WithMany("Concentrations")
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.UserClass", b =>
                {
                    b.HasOne("StarterProject.Api.Features.Users.Class", "Class")
                        .WithMany("UsersClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StarterProject.Api.Features.Users.User", "User")
                        .WithMany("UsersClasses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
