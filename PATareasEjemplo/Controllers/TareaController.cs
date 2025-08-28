using Microsoft.AspNetCore.Mvc;

namespace PATareasEjemplo.Controllers
{
    [ApiController]
    [Route("ejemplo-api/[controller]")]
    public class TareaController : Controller
    {

        [HttpGet("obtener-tareas")]
        public async Task<IActionResult> ObtenerTareas()
        {
            return Ok("Hola desde TareaController");
        }

    }
}
