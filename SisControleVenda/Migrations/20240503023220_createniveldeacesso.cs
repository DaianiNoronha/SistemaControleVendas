using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisControleVenda.Migrations
{
    /// <inheritdoc />
    public partial class createniveldeacesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NivelDeAcesso",
                columns: table => new
                {
                    NivelDeAcessoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelDeAcesso", x => x.NivelDeAcessoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NivelDeAcesso");
        }
    }
}
