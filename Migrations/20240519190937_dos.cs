using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNewTechApi.Migrations
{
    public partial class dos : Migration
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

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    tareaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    usuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    fechaCreada = table.Column<string>(type: "TEXT", nullable: false),
                    fechaTerminada = table.Column<string>(type: "TEXT", nullable: false),
                    fechaVecimineto = table.Column<string>(type: "TEXT", nullable: false),
                    estado = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.tareaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(type: "TEXT", nullable: false),
                    apellido = table.Column<string>(type: "TEXT", nullable: false),
                    nombreUsuario = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    tipoControl = table.Column<string>(type: "TEXT", nullable: false),
                    tipoUsuario = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Edicion", "Nombre", "NombreAutor", "Precio" },
                values: new object[] { 100, "Tercera", "El Coronel no tiene quien le escriba", "Grabriel Garcia Marquez", 1000m });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "usuarioId", "apellido", "nombre", "nombreUsuario", "password", "tipoControl", "tipoUsuario" },
                values: new object[] { 100, "admin", "Super", "admin", "admin", "Tareas", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
