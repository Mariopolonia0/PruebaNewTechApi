using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaNewTechApi.Model
{

    public class Licencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LicenciaId { get; set; }
        public String NumeroLicencia { get; set; } = string.Empty;
        public String NombreCliente { get; set; } = string.Empty;
        public String DireccionCliente { get; set; } = string.Empty;
        public Double CostoLicencia { get; set; }
    }
}
