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
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GlicemiaMedida = table.Column<int>(type: "int", nullable: false),
                    DoseRegulat = table.Column<int>(type: "int", nullable: true),
                    DoseAjuste = table.Column<int>(type: "int", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLICEMIAS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GLICEMIAS");
        }
    }
}
