using Microsoft.AspNetCore.Mvc;
using VueCineApi.Dtos;
using VueCineApi.Models;
using VueCineApi.Services;

namespace VueCineApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CineController : ControllerBase
    {
        private readonly ICineServices _cineService;

        public CineController(ICineServices cineService)
        {
            _cineService = cineService;
        }

        // GET: api/Cines
        [HttpGet]
        public ActionResult<IEnumerable<Cine>> GetAllCines()
        {
            var cines = _cineService.GetAllCines();
            return Ok(cines);
        }

        // GET: api/Cines/{id}
        [HttpGet("{id}")]
        public ActionResult<Cine> GetCineById(int id)
        {
            var cine = _cineService.GetCineById(id);
            if (cine == null)
            {
                return NotFound();
            }
            return Ok(cine);
        }

        // POST: api/Cines
        [HttpPost]
        public ActionResult<Cine> AddCine([FromBody] AddCineDto cine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _cineService.AddCine(cine);
            // Retorna el cine creado con el código de estado 201 (Created)
            return NoContent();
        }

        // PUT: api/Cines/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCine(int id, [FromBody] Cine cine)
        {
            if (id != cine.CineId || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var existingCine = _cineService.GetCineById(id);
            if (existingCine == null)
            {
                return NotFound();
            }

            _cineService.UpdateCine(cine);
            return NoContent(); // Retorna un código 204 (No Content) tras una actualización exitosa
        }

        // DELETE: api/Cines/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCine(int id)
        {
            var cine = _cineService.GetCineById(id);
            if (cine == null)
            {
                return NotFound();
            }

            _cineService.DeleteCine(id);
            return NoContent(); // Retorna un código 204 (No Content) tras borrar el cine
        }
    }
}
