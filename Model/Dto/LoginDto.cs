namespace PruebaNewTechApi.Model.Dto
{
    public class LoginDto
    {
        public int estudianteId { get; set; }
        public string nombreEstudiante { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        public LoginDto(int estudianteId, string nombres, string password)
        {
            this.estudianteId = estudianteId;
            nombreEstudiante = nombres;
            this.password = password;
        }
    }
}
