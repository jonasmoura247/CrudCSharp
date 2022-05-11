using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudCSharp.Migrations
{
    public partial class AtualizacaoMusicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Musicas",
                table: "Musicas");

            migrationBuilder.RenameTable(
                name: "Musicas",
                newName: "tb_musica");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_musica",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_musica",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Lancamento",
                table: "tb_musica",
                newName: "data_lancamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_musica",
                table: "tb_musica",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_musica",
                table: "tb_musica");

            migrationBuilder.RenameTable(
                name: "tb_musica",
                newName: "Musicas");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Musicas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Musicas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_lancamento",
                table: "Musicas",
                newName: "Lancamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musicas",
                table: "Musicas",
                column: "Id");
        }
    }
}
