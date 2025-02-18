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
        public string NotaTerminada { get; set; } = string.Empty;
        public string FechaCreada { get; set; } = string.Empty;
        public string FechaEmpezada { get; set; } = string.Empty;
        public string FechaTerminada { get; set; } = string.Empty;
        public string FechaVecimineto { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
