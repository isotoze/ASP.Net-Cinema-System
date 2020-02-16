using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCinemaApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    bbfcRating = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    releaseDate = table.Column<DateTime>(nullable: false),
                    genre = table.Column<string>(nullable: true),
                    imageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
