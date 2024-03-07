using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Controllers;

namespace VueCineApi.Models
{
    public class Cine
    {
        public int CineId { get; set;}
        public string? Nombre { get; set;}
        public DateTime Horario { get; set;}
        public int? NumSalas { get; set; }
        public List<Sala> Salas { get; set;}
    }
}