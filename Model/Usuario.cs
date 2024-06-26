using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNewTechApi.Model
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string NumeroLicencia { get; set; } = string.Empty;
        public Usuario() { }    

        public Usuario(int usuarioId, string nombre)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellido = "null";
            NombreUsuario = "null";
            Password = "null";
            NumeroLicencia = "null";
        }
    }
}