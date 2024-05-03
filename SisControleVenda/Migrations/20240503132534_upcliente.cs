using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisControleVenda.Migrations
{
    /// <inheritdoc />
    public partial class upcliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdministradorNome",
                table: "Cliente",
                newName: "ClienteSobrenome");

            migrationBuilder.RenameColumn(
                name: "AdministradorCPF",
                table: "Cliente",
                newName: "ClienteNome");

            migrationBuilder.RenameColumn(
                name: "AdmSobrenome",
                table: "Cliente",
                newName: "ClienteCPF");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ClienteDtNasc",
                table: "Cliente",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteDtNasc",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "ClienteSobrenome",
                table: "Cliente",
                newName: "AdministradorNome");

            migrationBuilder.RenameColumn(
                name: "ClienteNome",
                table: "Cliente",
                newName: "AdministradorCPF");

            migrationBuilder.RenameColumn(
                name: "ClienteCPF",
                table: "Cliente",
                newName: "AdmSobrenome");
        }
    }
}
