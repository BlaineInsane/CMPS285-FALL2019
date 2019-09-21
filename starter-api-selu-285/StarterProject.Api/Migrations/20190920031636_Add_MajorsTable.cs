using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_MajorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MajornName = table.Column<string>(nullable: true),
                    ConcentrationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 153, 125, 192, 25, 77, 139, 50, 150, 172, 236, 117, 214, 148, 50, 125, 194, 240, 70, 219, 179 }, new byte[] { 47, 63, 110, 25, 245, 25, 190, 25, 232, 42, 126, 139, 28, 92, 178, 113 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 160, 38, 182, 201, 134, 54, 32, 39, 214, 149, 226, 252, 252, 171, 32, 71, 119, 108, 6 }, new byte[] { 132, 221, 81, 176, 206, 91, 229, 59, 120, 83, 161, 185, 54, 129, 21, 53 } });
        }
    }
}
