using Microsoft.AspNetCore.Mvc;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Dtos;

namespace VueCineApi.Controllers{
[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    // GET: api/Movies
    [HttpGet]
    public ActionResult<IEnumerable<Movie>> GetAllMovies()
    {
        var movies = _movieService.GetAllMovies();
        return Ok(movies);
    }

    // GET: api/Movies/{id}
    [HttpGet("{id}")]
    public ActionResult<Movie> GetMovieById(int id)
    {
        var movie = _movieService.GetMovieById(id);
        if (movie == null)
        {
            return NotFound();
        }
        return Ok(movie);
    }

    // POST: api/Movies
    [HttpPost]
    public ActionResult<Movie> AddMovie([FromBody] AddMovieDto movie)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _movieService.AddMovie(movie);
        // Retorna la película creada con el código de estado 201 (Created)
        return NoContent();
    }

    // PUT: api/Movies/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] Movie movie)
    {
        if (id != movie.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        var existingMovie = _movieService.GetMovieById(id);
        if (existingMovie == null)
        {
            return NotFound();
        }

        _movieService.UpdateMovie(movie);
        return NoContent(); // Retorna un código 204 (No Content) tras una actualización exitosa
    }

    // DELETE: api/Movies/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id) 
    {
        var movie = _movieService.GetMovieById(id);
        if (movie == null)
        {
            return NotFound();
        }

        _movieService.DeleteMovie(id);
        return NoContent(); // Retorna un código 204 (No Content) tras borrar la película
    }
}
}