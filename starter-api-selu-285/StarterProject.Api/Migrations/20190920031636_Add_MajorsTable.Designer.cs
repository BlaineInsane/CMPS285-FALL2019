﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterProject.Api.Data;

namespace StarterProject.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190920031636_Add_MajorsTable")]
    partial class Add_MajorsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("ClassesConcentrations");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.Concentration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcentrationName");

                    b.HasKey("Id");

                    b.ToTable("Concentrations");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConcentrationId");

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
                            PasswordHash = new byte[] { 153, 125, 192, 25, 77, 139, 50, 150, 172, 236, 117, 214, 148, 50, 125, 194, 240, 70, 219, 179 },
                            PasswordSalt = new byte[] { 47, 63, 110, 25, 245, 25, 190, 25, 232, 42, 126, 139, 28, 92, 178, 113 },
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

                    b.ToTable("UsersClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
