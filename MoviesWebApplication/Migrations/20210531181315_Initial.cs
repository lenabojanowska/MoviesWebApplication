using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesWebApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toplists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toplists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieDBO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    ToplistDBOId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDBO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieDBO_toplists_ToplistDBOId",
                        column: x => x.ToplistDBOId,
                        principalTable: "toplists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieDBO_ToplistDBOId",
                table: "MovieDBO",
                column: "ToplistDBOId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDBO");

            migrationBuilder.DropTable(
                name: "toplists");
        }
    }
}
