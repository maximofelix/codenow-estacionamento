using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstacionamentoCode.Mvc.Migrations
{
    public partial class AddClasseVagas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Estacionamentos_EstacionamentoId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_EstacionamentoId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "EstacionamentoId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "HoraEntrada",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "HoraSaida",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "TempoEstacionado",
                table: "Veiculos");

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstacionamentoId = table.Column<int>(type: "int", nullable: false),
                    VeiculoId = table.Column<int>(type: "int", nullable: false),
                    Ocupada = table.Column<bool>(type: "bit", nullable: false),
                    HoraEntrada = table.Column<int>(type: "int", nullable: false),
                    HoraSaida = table.Column<int>(type: "int", nullable: true),
                    TempoEstacionado = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaga_Estacionamentos_EstacionamentoId",
                        column: x => x.EstacionamentoId,
                        principalTable: "Estacionamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaga_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_EstacionamentoId",
                table: "Vaga",
                column: "EstacionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_VeiculoId",
                table: "Vaga",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaga");

            migrationBuilder.AddColumn<int>(
                name: "EstacionamentoId",
                table: "Veiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HoraEntrada",
                table: "Veiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HoraSaida",
                table: "Veiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempoEstacionado",
                table: "Veiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_EstacionamentoId",
                table: "Veiculos",
                column: "EstacionamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Estacionamentos_EstacionamentoId",
                table: "Veiculos",
                column: "EstacionamentoId",
                principalTable: "Estacionamentos",
                principalColumn: "Id");
        }
    }
}
