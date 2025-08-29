using PATareasEjemplo.Models;

namespace PATareasEjemplo.Services
{
    public class TareaService
    {
        public async Task<List<Tarea>> ListarTareas()
        {
            // Simula una llamada a la base de datos

            var tareas = Tarea.ObtenerTareas();

            return tareas;
        }
    }
}
