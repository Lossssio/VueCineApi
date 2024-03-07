using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Controllers;

namespace VueCineApi.Models
{
    public class Sala
    {
        public int SalaId { get; set;}
        public string? Capacidad { get; set;}
        public string? Estado{ get; set;}
        public DateTime Horario { get; set;}
        public int CineId { get; set;}
        public Cine Cine { get; set; }
        public List<Sesion> Sesiones { get; set; }
        public List<Asiento> Asientos { get; set;}
    }
}
