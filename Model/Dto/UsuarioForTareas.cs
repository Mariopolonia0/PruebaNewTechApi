namespace PruebaNewTechApi.Model.Dto
{
    public class UsuarioForTareas
    {
        public int UsuarioId { get; set; } = 0;
        public string nombreAndApellido { get; set; } = string.Empty;

        public UsuarioForTareas(int usuarioId, string nombreAndApellido)
        {
            UsuarioId = usuarioId;
            this.nombreAndApellido = nombreAndApellido;
        }
    }
}
