using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstacionamentoCode.Mvc.Migrations
{
    public partial class InicialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estacionamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecoInicial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoHora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tolerancia = table.Column<int>(type: "int", nullable: false),
                    QtdeVagasTotais = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraEntrada = table.Column<int>(type: "int", nullable: false),
                    HoraSaida = table.Column<int>(type: "int", nullable: false),
                    TempoEstacionado = table.Column<int>(type: "int", nullable: false),
                    TipoDeVeiculo = table.Column<int>(type: "int", nullable: false),
                    EstacionamentoId = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculos_Estacionamentos_EstacionamentoId",
                        column: x => x.EstacionamentoId,
                        principalTable: "Estacionamentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_EstacionamentoId",
                table: "Veiculos",
                column: "EstacionamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Estacionamentos");
        }
    }
}
