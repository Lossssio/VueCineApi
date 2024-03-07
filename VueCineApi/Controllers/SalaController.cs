using Microsoft.AspNetCore.Mvc;
using VueCineApi.Dtos;
using VueCineApi.Models;
using VueCineApi.Services;

namespace VueCineApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaController : ControllerBase
    {
        private readonly ISalaServices _salaService;

        public SalaController(ISalaServices salaService)
        {
            _salaService = salaService;
        }

        // GET: api/Salas
        [HttpGet]
        public ActionResult<IEnumerable<Sala>> GetAllSalas()
        {
            var salas = _salaService.GetAllSalas();
            return Ok(salas);
        }

        // GET: api/Salas/{id}
        [HttpGet("{id}")]
        public ActionResult<Sala> GetSalaById(int id)
        {
            var sala = _salaService.GetSalaById(id);
            if (sala == null)
            {
                return NotFound();
            }
            return Ok(sala);
        }

        // POST: api/Salas
        [HttpPost]
        public ActionResult<Sala> AddSala([FromBody] AddSalaDto sala)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _salaService.AddSala(sala);
            // Retorna la sala creada con el código de estado 201 (Created)
            return NoContent();
        }

        // PUT: api/Salas/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateSala(int id, [FromBody] Sala sala)
        {
            if (id != sala.SalaId || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var existingSala = _salaService.GetSalaById(id);
            if (existingSala == null)
            {
                return NotFound();
            }

            _salaService.UpdateSala(sala);
            return NoContent(); // Retorna un código 204 (No Content) tras una actualización exitosa
        }

        // DELETE: api/Salas/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteSala(int id)
        {
            var sala = _salaService.GetSalaById(id);
            if (sala == null)
            {
                return NotFound();
            }

            _salaService.DeleteSala(id);
            return NoContent(); // Retorna un código 204 (No Content) tras borrar la sala
        }
    }
}
