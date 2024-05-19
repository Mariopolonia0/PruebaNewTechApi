

using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.Model;
using PruebaNewTechApi.Model.ControlTarea;

namespace PruebaNewTechApi.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Book>? Book { set; get; }
        public DbSet<Usuario>? Usuarios { set; get; }
        public DbSet<Tarea>? Tarea { set; get; }

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