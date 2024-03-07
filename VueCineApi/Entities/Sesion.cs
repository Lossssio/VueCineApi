using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Controllers;

namespace VueCineApi.Models
{
    public class Sesion
    {
        public int? SesionId { get; set;}
        public DateTime Horario{ get; set; }
        public decimal PrecioEntrada { get; set; }
        //esto es para acceder a los atributos de sala y movie
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}