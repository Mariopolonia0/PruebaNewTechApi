namespace PruebaNewTechApi.Model.Dto
{
    public class LoginIn
    {
        public string nombreEstudiante { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        public LoginIn(int estudianteId, string nombres, string password)
        {
            nombreEstudiante = nombres;
            this.password = password;
        }
    }
}
