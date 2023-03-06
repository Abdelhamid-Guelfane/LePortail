using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LePortail.Migrations
{
    /// <inheritdoc />
    public partial class uploadcv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CheminDuCv",
                schema: "EspaceCandidat",
                table: "Candidat",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheminDuCv",
                schema: "EspaceCandidat",
                table: "Candidat");
        }
    }
}
