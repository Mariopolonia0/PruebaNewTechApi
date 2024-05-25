using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaNewTechApi.Model
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TareaId { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public String FechaCreada { get; set; } = String.Empty;
        public string FechaTerminada { get; set; } = string.Empty;
        public string FechaVecimineto { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
