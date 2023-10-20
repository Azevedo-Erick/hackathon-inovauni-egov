using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackatonInovaUniEGov.Migrations
{
    /// <inheritdoc />
    public partial class second_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServicoPublicoId",
                table: "questionario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_questionario_ServicoPublicoId",
                table: "questionario",
                column: "ServicoPublicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_questionario_servicos_publicos_ServicoPublicoId",
                table: "questionario",
                column: "ServicoPublicoId",
                principalTable: "servicos_publicos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questionario_servicos_publicos_ServicoPublicoId",
                table: "questionario");

            migrationBuilder.DropIndex(
                name: "IX_questionario_ServicoPublicoId",
                table: "questionario");

            migrationBuilder.DropColumn(
                name: "ServicoPublicoId",
                table: "questionario");
        }
    }
}
