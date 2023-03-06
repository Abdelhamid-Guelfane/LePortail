using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LePortail.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EspaceCandidat");

            migrationBuilder.CreateTable(
                name: "Candidat",
                schema: "EspaceCandidat",
                columns: table => new
                {
                    IdCandidat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "varchar(50)", nullable: false),
                    Prenom = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Tel = table.Column<short>(type: "smallint", nullable: false),
                    NiveauDetude = table.Column<string>(type: "varchar(30)", nullable: false),
                    AnneesExperience = table.Column<string>(type: "varchar(30)", nullable: false),
                    DernierEmployeur = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.IdCandidat);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidat",
                schema: "EspaceCandidat");
        }
    }
}
