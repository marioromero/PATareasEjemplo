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

        /* Simula la carga de tareas desde la BD*/

        public static List<Tarea> ObtenerTareas()
        {
            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea()
            {
                Id = 1,
                Descripcion = "Tarea 1",
                FechaIngreso = DateTime.Now,
                FechaInicio = DateTime.Now.AddDays(1),
                Estado = "Pendiente",
                Responsable = 1
            });

            tareas.Add(new Tarea()
            {
                Id = 2,
                Descripcion = "Tarea 2",
                FechaIngreso = DateTime.Now,
                FechaInicio = DateTime.Now.AddDays(2),
                Estado = "En Proceso",
                Responsable = 2
            });

            return tareas;
        }
    }


}
