using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_ClassesConcentrationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassesConcentrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(nullable: false),
                    ConcentrationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassesConcentrations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 94, 194, 169, 122, 122, 160, 158, 203, 26, 205, 179, 13, 165, 60, 203, 38, 93, 101, 95, 189 }, new byte[] { 77, 236, 79, 230, 16, 182, 219, 52, 194, 242, 186, 170, 95, 228, 204, 158 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassesConcentrations");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 50, 38, 125, 159, 240, 180, 246, 63, 108, 212, 6, 173, 223, 92, 206, 163, 192, 160, 58, 137 }, new byte[] { 132, 204, 68, 199, 30, 133, 144, 175, 220, 39, 163, 62, 105, 231, 34, 82 } });
        }
    }
}
