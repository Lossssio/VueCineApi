using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Data;
using VueCineApi.Controllers;
using VueCineApi.Dtos;

namespace VueCineApi.Services{
public class MovieService : IMovieService
{
    private readonly MovieData _movieData;

    public MovieService(MovieData movieData)
    {
        _movieData = movieData;
    }

    public List<Movie> GetAllMovies()
    {
        return _movieData.GetAllMovies();
    }

    public Movie GetMovieById(int id)
    {
        return _movieData.GetMovieById(id);
    }

    public void AddMovie(AddMovieDto movieDto)
    {
            var movie = new Movie()
            {
                Id = movieDto.Id
            };
            _movieData.AddMovie(movie);
    }

    public void UpdateMovie(Movie updatedMovie)
    {
        _movieData.UpdateMovie(updatedMovie);
    }

    public void DeleteMovie(int id)
    {
        _movieData.DeleteMovie(id);
    }
}
}
