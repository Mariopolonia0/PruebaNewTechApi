using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaNewTechApi.Model
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public int Empresa { get; set; }
        public int Direccion { get; set; }
    }
}
