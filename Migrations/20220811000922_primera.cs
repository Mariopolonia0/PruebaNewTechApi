using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNewTechApi.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    NombreAutor = table.Column<string>(type: "TEXT", nullable: false),
                    Edicion = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Edicion", "Nombre", "NombreAutor", "Precio" },
                values: new object[] { 100, "Tercera", "El Coronel no tiene quien le escriba", "Grabriel Garcia Marquez", 1000m });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Edicion", "Nombre", "NombreAutor", "Precio" },
                values: new object[] { 101, "Primera", "El lenguaje de programacion C#", "Francisco Javier Ceballos", 10000m });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Edicion", "Nombre", "NombreAutor", "Precio" },
                values: new object[] { 103, "Tercera", "Kotlin in Action", "Dmitry Jemerov and Svetlana Isakova", 13000m });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Edicion", "Nombre", "NombreAutor", "Precio" },
                values: new object[] { 104, "Tercera", "Java 2 Manual de programacion", "Luis Joyanes Aguilar", 9000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
