using System.ComponentModel.DataAnnotations;

namespace PruebaNewTechApi.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreAutor { get; set; } = string.Empty;
        public string Edicion { get; set; } = string.Empty;
        public decimal Precio { get; set; } = 0;
    }
}