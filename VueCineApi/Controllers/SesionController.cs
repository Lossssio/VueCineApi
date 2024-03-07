using Microsoft.AspNetCore.Mvc;
using VueCineApi.Dtos;
using VueCineApi.Models;
using VueCineApi.Services;

namespace VueCineApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SesionController : ControllerBase
    {
        private readonly ISesionService _sesionService;

        public SesionController(ISesionService sesionService)
        {
            _sesionService = sesionService;
        }

        // GET: api/Sesiones
        [HttpGet]
        public ActionResult<IEnumerable<Sesion>> GetAllSesiones()
        {
            var sesiones = _sesionService.GetAllSesiones();
            return Ok(sesiones);
        }

        // GET: api/Sesiones/{id}
        [HttpGet("{id}")]
        public ActionResult<Sesion> GetSesionById(int id)
        {
            var sesion = _sesionService.GetSesionById(id);
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);
        }

        // POST: api/Sesiones
        [HttpPost]
        public ActionResult<Sesion> AddSesion([FromBody] AddSesionDto sesion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _sesionService.AddSesion(sesion);
            // Retorna la sesión creada con el código de estado 201 (Created)
            return NoContent();
        }

        // PUT: api/Sesiones/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateSesion(int id, [FromBody] Sesion sesion)
        {
            if (id != sesion.SesionId || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var existingSesion = _sesionService.GetSesionById(id);
            if (existingSesion == null)
            {
                return NotFound();
            }

            _sesionService.UpdateSesion(sesion);
            return NoContent(); // Retorna un código 204 (No Content) tras una actualización exitosa
        }

        // DELETE: api/Sesiones/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteSesion(int id)
        {
            var sesion = _sesionService.GetSesionById(id);
            if (sesion == null)
            {
                return NotFound();
            }

            _sesionService.DeleteSesion(id);
            return NoContent(); // Retorna un código 204 (No Content) tras borrar la sesión
        }
    }
}
