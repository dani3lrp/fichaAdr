using Microsoft.EntityFrameworkCore.Migrations;

namespace fichaAdr.Migrations
{
    public partial class ApplyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Fichas_FichaId",
                table: "Tipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo");

            migrationBuilder.RenameTable(
                name: "Tipo",
                newName: "Tipos");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_FichaId",
                table: "Tipos",
                newName: "IX_Tipos_FichaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Fichas",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tipos",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Fichas_FichaId",
                table: "Tipos",
                column: "FichaId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Fichas_FichaId",
                table: "Tipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.RenameTable(
                name: "Tipos",
                newName: "Tipo");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_FichaId",
                table: "Tipo",
                newName: "IX_Tipo_FichaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Fichas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tipo",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Fichas_FichaId",
                table: "Tipo",
                column: "FichaId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
