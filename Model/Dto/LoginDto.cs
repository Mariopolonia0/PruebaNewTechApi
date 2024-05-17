namespace PruebaNewTechApi.Model.Dto
{
    public class LoginDto
    {
        public int usuarioId { get; set; }
        public string nombreEstudiante { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        public LoginDto(int usuarioId, string nombre, string password)
        {
            this.usuarioId = usuarioId;
            this.nombreEstudiante = nombre;
            this.password = password;
        }
    }
}
