using Microsoft.AspNetCore.Mvc;
using PATareasEjemplo.Responses;
using PATareasEjemplo.Services;

namespace PATareasEjemplo.Controllers
{

    [ApiController]
    [Route("ejemplo-api/[controller]")]
    public class TareaController : Controller
    {

        private readonly TareaService _tareaService;

        public TareaController()
        {
            _tareaService = new TareaService();
        }

        [HttpGet("obtener-tareas")]
        public async Task<ActionResult<TareasResponse>> ObtenerTareas()
        {
            var tareas = await _tareaService.ListarTareas();

            var response = new TareasResponse()
            {
                Data = tareas,
                Status = true,
                Message = "Tareas obtenidas correctamente"
            };

            return Ok(response);

        }

    }
}
