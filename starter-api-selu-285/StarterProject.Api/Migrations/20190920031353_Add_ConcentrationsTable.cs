using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_ConcentrationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concentrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcentrationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concentrations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 160, 38, 182, 201, 134, 54, 32, 39, 214, 149, 226, 252, 252, 171, 32, 71, 119, 108, 6 }, new byte[] { 132, 221, 81, 176, 206, 91, 229, 59, 120, 83, 161, 185, 54, 129, 21, 53 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concentrations");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 94, 194, 169, 122, 122, 160, 158, 203, 26, 205, 179, 13, 165, 60, 203, 38, 93, 101, 95, 189 }, new byte[] { 77, 236, 79, 230, 16, 182, 219, 52, 194, 242, 186, 170, 95, 228, 204, 158 } });
        }
    }
}
