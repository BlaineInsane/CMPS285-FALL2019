using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_UsersClassesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    ClassCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersClasses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 84, 80, 37, 158, 159, 215, 104, 252, 194, 202, 59, 183, 119, 228, 204, 107, 92, 183, 197 }, new byte[] { 212, 150, 32, 100, 209, 145, 0, 67, 40, 69, 181, 61, 193, 158, 27, 65 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersClasses");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 0, 134, 155, 204, 60, 163, 192, 103, 187, 33, 188, 6, 237, 25, 96, 113, 12, 157, 184, 190 }, new byte[] { 77, 20, 75, 188, 204, 204, 189, 87, 160, 189, 71, 161, 6, 131, 189, 56 } });
        }
    }
}
