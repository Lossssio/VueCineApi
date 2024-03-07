using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Data;
using VueCineApi.Controllers;
using VueCineApi.Dtos;

namespace VueCineApi.Services{
public interface IMovieService
{
    List<Movie> GetAllMovies();
    Movie GetMovieById(int id);
    void AddMovie(AddMovieDto movie);
    void UpdateMovie(Movie updatedMovie);
    void DeleteMovie(int id);
}
}