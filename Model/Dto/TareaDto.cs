namespace PruebaNewTechApi.Model.Dto
{
    public class TareaDto : Tarea
    {
        public string NombreAndApellido { get; set; } = string.Empty;
        public TareaDto(Usuario usuario, Tarea tarea)
        {
            if (usuario != null)
            {
                this.NombreAndApellido = usuario.Nombre + " " + usuario.Apellido;
            }
            this.UsuarioId = tarea.UsuarioId;
            this.TareaId = tarea.TareaId;
            this.Descripcion = tarea.Descripcion;
            this.Cliente = tarea.Cliente; 
            this.NotaTerminada = tarea.NotaTerminada;
            this.FechaEmpezada = tarea.FechaEmpezada;
            this.FechaCreada = tarea.FechaCreada;
            this.FechaTerminada = tarea.FechaTerminada;
            this.FechaVecimineto = tarea.FechaVecimineto;
            this.Direccion = tarea.Direccion;
            this.Estado = tarea.Estado;
        }
    }

}
