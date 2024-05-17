

using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.Model;

namespace PruebaNewTechApi.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Book>? Book { set; get; }
        public DbSet<Usuario>? Usuarios { set; get; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 100,
                Nombre = "El Coronel no tiene quien le escriba",
                NombreAutor = "Grabriel Garcia Marquez",
                Edicion = "Tercera",
                Precio = 1000
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 101,
                Nombre = "El lenguaje de programacion C#",
                NombreAutor = "Francisco Javier Ceballos",
                Edicion = "Primera",
                Precio = 10000
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 103,
                Nombre = "Kotlin in Action",
                NombreAutor = "Dmitry Jemerov and Svetlana Isakova",
                Edicion = "Tercera",
                Precio = 13000
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 104,
                Nombre = "Java 2 Manual de programacion",
                NombreAutor = "Luis Joyanes Aguilar",
                Edicion = "Tercera",
                Precio = 9000
            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                usuarioId = 100,
                nombre = "Super",
                apellido = "admin",
                nombreUsuario = "admin",
                password = "admin"
            });
        }
    }
}