using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Controllers;

namespace VueCineApi.Data{
public class MovieData
{
    //esto es para que atraves de _context puedas hacer crud a la bbdd(dbcontext)
    private readonly ApplicationDbContext _context;
//se crea una instancia de ApplicationDbContext con context y luego se le da el valor a _context
//es como hacer esto ApplicationDbContext context= new ApplicationDbContext() y luego hacer lo de igual 
    public MovieData(ApplicationDbContext context)
    {
        _context = context;
    }

    // Método para obtener todas las películas
    public List<Movie> GetAllMovies()
    {
        //tolist ejecuta el codigo en la bbdd
        return _context.Movies.ToList();
    }

    // Método para obtener una película por su ID
    //Movie representa cada pelicula en individual
    public Movie GetMovieById(int id)
    {
        //FirstOrDefault es un metodo de linq q devuelve el 1 valor q cumpla el landa(m => m.id == id)
        return _context.Movies.FirstOrDefault(m => m.Id == id);
    }

    // Método para agregar una nueva película
    //esto espera q se le pase un objeto de tipo Movie y movie tiene los datos de la peli q quiere agregar
    public void AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    // Método para actualizar una película existente
    public void UpdateMovie(Movie updatedMovie)
    {
        var existingMovie = _context.Movies.FirstOrDefault(m => m.Id == updatedMovie.Id);
        if (existingMovie != null)
        {
            existingMovie.Image = updatedMovie.Image;
            existingMovie.Title = updatedMovie.Title;
            existingMovie.Director = updatedMovie.Director;
            existingMovie.Actors = updatedMovie.Actors;
            existingMovie.Description = updatedMovie.Description;
            _context.SaveChanges();
        }
    }

    // Método para eliminar una película
    public void DeleteMovie(int id)
    {
        var movieToDelete = _context.Movies.FirstOrDefault(m => m.Id == id);
        if (movieToDelete != null)
        {
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();
        }
    }
}
}
