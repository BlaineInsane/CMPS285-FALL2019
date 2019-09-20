using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_ClassesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    ClassDescription = table.Column<string>(nullable: true),
                    CreditHours = table.Column<int>(nullable: false),
                    Prerequisite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 50, 38, 125, 159, 240, 180, 246, 63, 108, 212, 6, 173, 223, 92, 206, 163, 192, 160, 58, 137 }, new byte[] { 132, 204, 68, 199, 30, 133, 144, 175, 220, 39, 163, 62, 105, 231, 34, 82 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 84, 80, 37, 158, 159, 215, 104, 252, 194, 202, 59, 183, 119, 228, 204, 107, 92, 183, 197 }, new byte[] { 212, 150, 32, 100, 209, 145, 0, 67, 40, 69, 181, 61, 193, 158, 27, 65 } });
        }
    }
}
