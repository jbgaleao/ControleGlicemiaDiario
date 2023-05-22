using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleGlicemiaDiario.Migrations
{
    public partial class InicialCriaBDeTabelaGlicemia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GLICEMIAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraMedicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GlicemiaMedida = table.Column<int>(type: "int", nullable: false),
                    DoseRegular = table.Column<int>(type: "int", nullable: true),
                    DoseAjuste = table.Column<int>(type: "int", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLICEMIAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlicemiaVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraMedicao = table.Column<DateTime>(type: "datetime2", maxLength: 14, nullable: false),
                    DataHoraAplicação = table.Column<DateTime>(type: "datetime2", maxLength: 14, nullable: false),
                    GlicemiaMedida = table.Column<int>(type: "int", nullable: false),
                    DoseRegular = table.Column<int>(type: "int", nullable: true),
                    DoseAjuste = table.Column<int>(type: "int", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlicemiaVM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GLICEMIAS");

            migrationBuilder.DropTable(
                name: "GlicemiaVM");
        }
    }
}
