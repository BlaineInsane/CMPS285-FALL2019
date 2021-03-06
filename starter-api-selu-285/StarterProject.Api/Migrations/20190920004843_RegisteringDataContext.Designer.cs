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
    [Migration("20190920004843_RegisteringDataContext")]
    partial class RegisteringDataContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarterProject.Api.Features.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

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
                            LastName = "Seeded-Admin-LastName",
                            PasswordHash = new byte[] { 193, 41, 230, 209, 207, 133, 68, 35, 44, 238, 247, 161, 119, 57, 162, 155, 100, 23, 220, 230 },
                            PasswordSalt = new byte[] { 82, 206, 12, 140, 142, 176, 152, 110, 1, 142, 158, 14, 197, 47, 222, 66 },
                            Role = "Admin",
                            Username = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
