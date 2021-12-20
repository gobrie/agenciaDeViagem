using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AGV.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServicoIdservico",
                table: "Usuário",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuário_ServicoIdservico",
                table: "Usuário",
                column: "ServicoIdservico");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuário_Serviço_ServicoIdservico",
                table: "Usuário",
                column: "ServicoIdservico",
                principalTable: "Serviço",
                principalColumn: "ID Serviço");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuário_Serviço_ServicoIdservico",
                table: "Usuário");

            migrationBuilder.DropIndex(
                name: "IX_Usuário_ServicoIdservico",
                table: "Usuário");

            migrationBuilder.DropColumn(
                name: "ServicoIdservico",
                table: "Usuário");
        }
    }
}
