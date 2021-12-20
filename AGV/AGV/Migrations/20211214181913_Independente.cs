using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AGV.Migrations
{
    public partial class Independente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    IDPEDIDO = table.Column<int>(name: "ID PEDIDO", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipodePagamento = table.Column<string>(name: "Tipo de Pagamento", type: "nvarchar(max)", nullable: false),
                    CupomdeDesconto = table.Column<string>(name: "Cupom de Desconto", type: "nvarchar(max)", nullable: false),
                    Promoção = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.IDPEDIDO);
                });

            migrationBuilder.CreateTable(
                name: "Serviço",
                columns: table => new
                {
                    IDServiço = table.Column<int>(name: "ID Serviço", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatadaIda = table.Column<DateTime>(name: "Data da Ida", type: "datetime2", nullable: false),
                    DatadaVolta = table.Column<DateTime>(name: "Data da Volta", type: "datetime2", nullable: false),
                    QuantidadedePassageiros = table.Column<int>(name: "Quantidade de Passageiros", type: "int", nullable: false),
                    Preço = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serviço", x => x.IDServiço);
                });

            migrationBuilder.CreateTable(
                name: "Usuário",
                columns: table => new
                {
                    IDUsuario = table.Column<int>(name: "ID Usuario", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereço = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuário", x => x.IDUsuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Serviço");

            migrationBuilder.DropTable(
                name: "Usuário");
        }
    }
}
