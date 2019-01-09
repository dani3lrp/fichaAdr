using Microsoft.EntityFrameworkCore.Migrations;

namespace fichaAdr.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Fichas (NumeroAdr, Nombre) VALUES (1000, 'Ficha1')");
            migrationBuilder.Sql("INSERT INTO Fichas (NumeroAdr, Nombre) VALUES (1002, 'Ficha2')");
            migrationBuilder.Sql("INSERT INTO Fichas (NumeroAdr, Nombre) VALUES (1003, 'Ficha3')");

            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha1-TipoA', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha1'))");
            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha1-TipoB', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha1'))");
            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha1-TipoC', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha1'))");

            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha2-TipoA', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha2'))");
            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha2-TipoB', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha2'))");
            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha2-TipoC', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha2'))");

            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha3-TipoA', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha3'))");
            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha3-TipoB', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha3'))");
            migrationBuilder.Sql("INSERT INTO Tipos (Nombre, FichaID) VALUES ('Ficha3-TipoC', (SELECT ID FROM Fichas WHERE Nombre = 'Ficha3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Fichas WHERE Nombre IN ('Ficha1', 'Ficha2', 'Ficha3')");

        }
    }
}
