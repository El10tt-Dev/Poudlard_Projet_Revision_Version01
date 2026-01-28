using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poudlard.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateNaissance = table.Column<DateOnly>(type: "date", nullable: false),
                    Type_personne = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Baguette = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "NON_RENSEIGNEE"),
                    FideleVoldemort = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    PeutEntrerPoudlard = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Annee = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Maison = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "None"),
                    PointGagne = table.Column<int>(type: "int", nullable: true),
                    PointPerdu = table.Column<int>(type: "int", nullable: true),
                    CourAttribue = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ChefMaison = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Professeur_Maison = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "None")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
