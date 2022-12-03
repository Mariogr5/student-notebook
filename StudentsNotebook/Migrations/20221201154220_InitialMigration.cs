using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsNotebook.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "curseslist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coursename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Professor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Learndifficulty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curseslist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "newcurseslist",
                columns: table => new
                {
                    Kursid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kursname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KursProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kurslearndifficulty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newcurseslist", x => x.Kursid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "curseslist");

            migrationBuilder.DropTable(
                name: "newcurseslist");
        }
    }
}
