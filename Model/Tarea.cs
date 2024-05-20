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
        public string Descripcion { get; set; }
        public String FechaCreada { get; set; }
        public string FechaTerminada { get; set; }
        public string FechaVecimineto { get; set; }
        public string Estado { get; set; }
    }
}
