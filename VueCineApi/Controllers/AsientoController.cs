using Microsoft.AspNetCore.Mvc;
using VueCineApi.Dtos;
using VueCineApi.Models;
using VueCineApi.Services;

namespace VueCineApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsientoController : ControllerBase
    {
        private readonly IAsientoService _asientoService;

        public AsientoController(IAsientoService asientoService)
        {
            _asientoService = asientoService;
        }

        // GET: api/Asientos
        [HttpGet]
        public ActionResult<IEnumerable<Asiento>> GetAllAsientos()
        {
            var asientos = _asientoService.GetAllAsientos();
            return Ok(asientos);
        }

        // GET: api/Asientos/{id}
        [HttpGet("{id}")]
        public ActionResult<Asiento> GetAsientoById(int id)
        {
            var asiento = _asientoService.GetAsientoById(id);
            if (asiento == null)
            {
                return NotFound();
            }
            return Ok(asiento);
        }

        // POST: api/Asientos
        [HttpPost]
        public ActionResult<Asiento> AddAsiento([FromBody] AddAsientoDto asiento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _asientoService.AddAsiento(asiento);
            return NoContent();
        }

        // PUT: api/Asientos/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateAsiento(int id, [FromBody] Asiento asiento)
        {
            if (id != asiento.AsientoId || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var existingAsiento = _asientoService.GetAsientoById(id);
            if (existingAsiento == null)
            {
                return NotFound();
            }

            _asientoService.UpdateAsiento(asiento);
            return NoContent(); // Retorna un código 204 (No Content) tras una actualización exitosa
        }

        // DELETE: api/Asientos/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteAsiento(int id)
        {
            var asiento = _asientoService.GetAsientoById(id);
            if (asiento == null)
            {
                return NotFound();
            }

            _asientoService.DeleteAsiento(id);
            return NoContent(); // Retorna un código 204 (No Content) tras borrar el asiento
        }
    }
}
