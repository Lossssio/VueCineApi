using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Controllers;

namespace VueCineApi.Models
{
    public class Asiento
    {
        public int? AsientoId { get; set;}
        public int? NumAsientos { get; set;}
        public DateTime Horario { get; set;}
        public string? Estado { get; set;}
        public string? Tipo { get; set;}
// Referencia a la Sala a la que pertenece este asiento
        public int SalaId { get; set; }
        public Sala Sala { get; set; }   
     }
}