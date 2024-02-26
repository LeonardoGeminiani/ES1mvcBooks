using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ES1.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medici",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cognome = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Specializzazione = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medici", x => x.MedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Reparti",
                columns: table => new
                {
                    RepartoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: true),
                    Piano = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroLetti = table.Column<int>(type: "INTEGER", nullable: false),
                    Primario = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparti", x => x.RepartoId);
                });

            migrationBuilder.CreateTable(
                name: "Pazienti",
                columns: table => new
                {
                    CF = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cognome = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascita = table.Column<int>(type: "INTEGER", nullable: false),
                    LuogoNascita = table.Column<string>(type: "TEXT", nullable: true),
                    Patologia = table.Column<string>(type: "TEXT", nullable: true),
                    Indirizzo = table.Column<string>(type: "TEXT", nullable: true),
                    Cap = table.Column<string>(type: "TEXT", nullable: true),
                    Citta = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    RepartoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pazienti", x => x.CF);
                    table.ForeignKey(
                        name: "FK_Pazienti_Reparti_RepartoId",
                        column: x => x.RepartoId,
                        principalTable: "Reparti",
                        principalColumn: "RepartoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terapie",
                columns: table => new
                {
                    CF = table.Column<string>(type: "TEXT", nullable: false),
                    FarmacoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInizio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFine = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Posologia = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapie", x => new { x.CF, x.FarmacoId });
                    table.ForeignKey(
                        name: "FK_Terapie_Pazienti_CF",
                        column: x => x.CF,
                        principalTable: "Pazienti",
                        principalColumn: "CF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visite",
                columns: table => new
                {
                    VisitaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ora = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: true),
                    StatoSalute = table.Column<string>(type: "TEXT", nullable: true),
                    PressioneMinima = table.Column<int>(type: "INTEGER", nullable: false),
                    PressioneMassima = table.Column<int>(type: "INTEGER", nullable: false),
                    Temperatura = table.Column<float>(type: "REAL", nullable: false),
                    FrequenzaCardiaca = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CF = table.Column<string>(type: "TEXT", nullable: true),
                    PazienteCF = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visite", x => x.VisitaId);
                    table.ForeignKey(
                        name: "FK_visite_Medici_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medici",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_visite_Pazienti_PazienteCF",
                        column: x => x.PazienteCF,
                        principalTable: "Pazienti",
                        principalColumn: "CF");
                });

            migrationBuilder.CreateTable(
                name: "Farmaci",
                columns: table => new
                {
                    FarmacoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: true),
                    PrincipioAttivo = table.Column<string>(type: "TEXT", nullable: true),
                    QuantitaScatole = table.Column<int>(type: "INTEGER", nullable: false),
                    Scadenza = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    CF = table.Column<string>(type: "TEXT", nullable: true),
                    TerapiaCF = table.Column<string>(type: "TEXT", nullable: true),
                    TerapiaFarmacoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmaci", x => x.FarmacoId);
                    table.ForeignKey(
                        name: "FK_Farmaci_Terapie_TerapiaCF_TerapiaFarmacoId",
                        columns: x => new { x.TerapiaCF, x.TerapiaFarmacoId },
                        principalTable: "Terapie",
                        principalColumns: new[] { "CF", "FarmacoId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Farmaci_TerapiaCF_TerapiaFarmacoId",
                table: "Farmaci",
                columns: new[] { "TerapiaCF", "TerapiaFarmacoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Pazienti_RepartoId",
                table: "Pazienti",
                column: "RepartoId");

            migrationBuilder.CreateIndex(
                name: "IX_visite_MedicoId",
                table: "visite",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_visite_PazienteCF",
                table: "visite",
                column: "PazienteCF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Farmaci");

            migrationBuilder.DropTable(
                name: "visite");

            migrationBuilder.DropTable(
                name: "Terapie");

            migrationBuilder.DropTable(
                name: "Medici");

            migrationBuilder.DropTable(
                name: "Pazienti");

            migrationBuilder.DropTable(
                name: "Reparti");
        }
    }
}
