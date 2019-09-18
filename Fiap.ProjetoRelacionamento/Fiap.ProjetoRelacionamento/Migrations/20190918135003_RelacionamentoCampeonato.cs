using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.ProjetoRelacionamento.Migrations
{
    public partial class RelacionamentoCampeonato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreinadorId",
                table: "Times",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Campeonatos",
                columns: table => new
                {
                    CampeonatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Premiacao = table.Column<decimal>(nullable: false),
                    TipoCampeonato = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonatos", x => x.CampeonatoId);
                });

            migrationBuilder.CreateTable(
                name: "jogadores",
                columns: table => new
                {
                    JogadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Altura = table.Column<float>(nullable: false),
                    TimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogadores", x => x.JogadorId);
                    table.ForeignKey(
                        name: "FK_jogadores_Times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Times",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treinadores",
                columns: table => new
                {
                    TreinadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Salario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinadores", x => x.TreinadorId);
                });

            migrationBuilder.CreateTable(
                name: "CampeonatoTime",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false),
                    CampeonatoId = table.Column<int>(nullable: false),
                    TipoCampeonato = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoTime", x => new { x.CampeonatoId, x.TimeId });
                    table.ForeignKey(
                        name: "FK_CampeonatoTime_Campeonatos_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonatos",
                        principalColumn: "CampeonatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampeonatoTime_Times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Times",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Times_TreinadorId",
                table: "Times",
                column: "TreinadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoTime_TimeId",
                table: "CampeonatoTime",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_jogadores_TimeId",
                table: "jogadores",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Times_Treinadores_TreinadorId",
                table: "Times",
                column: "TreinadorId",
                principalTable: "Treinadores",
                principalColumn: "TreinadorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Times_Treinadores_TreinadorId",
                table: "Times");

            migrationBuilder.DropTable(
                name: "CampeonatoTime");

            migrationBuilder.DropTable(
                name: "jogadores");

            migrationBuilder.DropTable(
                name: "Treinadores");

            migrationBuilder.DropTable(
                name: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Times_TreinadorId",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "TreinadorId",
                table: "Times");
        }
    }
}
