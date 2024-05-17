namespace PruebaNewTechApi.Model
{
    public class Usuario
    {

        public int usuarioId { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String nombreUsuario { get; set; }
        public String password { get; set; }
        public Usuario() { }

        public Usuario(int _usuarioId, string _nombre, string _apellido, string _nombreUsuario, string _password)
        {
            this.usuarioId = _usuarioId; 
            this.nombre = _nombre;   
            this.apellido = _apellido;  
            this.nombreUsuario = _nombreUsuario;
            this.password = _password;   
           
        }
    }
}
