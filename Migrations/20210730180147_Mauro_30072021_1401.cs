using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle_Financeiro.Migrations
{
    public partial class Mauro_30072021_1401 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Saldo",
                table: "Clientes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Valor_Emprestimo",
                table: "Clientes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saldo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Valor_Emprestimo",
                table: "Clientes");
        }
    }
}
