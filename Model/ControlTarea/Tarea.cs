namespace PruebaNewTechApi.Model.ControlTarea
{
    public class Tarea
    {
        public int tareaId { get; set; }
        public int usuarioId { get; set; }
        public string descripcion { get; set; }
        public String fechaCreada { get; set; }
        public string fechaTerminada { get; set; }
        public string fechaVecimineto { get; set; }
        public string estado { get; set; }
    }
}
