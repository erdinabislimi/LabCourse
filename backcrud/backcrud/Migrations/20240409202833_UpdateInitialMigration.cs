using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backcrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gjuha",
                table: "Librat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "Librat",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gjuha",
                table: "Librat");

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Librat");
        }
    }
}
