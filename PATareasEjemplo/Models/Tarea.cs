namespace PATareasEjemplo.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = "Sin descripcion";
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaInicio { get; set; }
        public string? Estado { get; set; }
        public int Responsable { get; set; }
    }
}
