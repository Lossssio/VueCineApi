using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Controllers;

namespace VueCineApi.Models{
public class Movie {
    public int? Id { get; set;}
    public string? Image { get; set;}
    public string? Title { get; set;}
    public string? Director { get; set;}
    public string? Actors { get; set;}
    public string? Description { get; set;}
    
}
}