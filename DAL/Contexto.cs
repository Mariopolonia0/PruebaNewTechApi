using Microsoft.EntityFrameworkCore;
using PruebaNewTechApi.Model;

namespace PruebaNewTechApi.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Book>? Book { set; get; }
        public DbSet<Usuario>? Usuario { set; get; }
        public DbSet<Tarea>? Tareas { set; get; }

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
                UsuarioId = 100,
                Nombre = "Super",
                Apellido = "admin",
                NombreUsuario = "admin",
                Password = "admin",
                NombreEmpresa = "SP"
            });
        }
    }
}