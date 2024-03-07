using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Controllers;

namespace VueCineApi.Data
{
    public class SesionData
    {
        private readonly ApplicationDbContext _context;

        // Constructor que recibe el contexto de la base de datos y lo asigna a la variable privada _context.
        public SesionData(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método para obtener todas las sesiones de la base de datos.
        public List<Sesion> GetAllSesiones()
        {
            // Utiliza LINQ para obtener todas las sesiones y convertirlas en una lista.
            return _context.Sesiones.ToList();
        }

        // Método para obtener una sesión por su ID.
        public Sesion GetSesionById(int id)
        {
            // Utiliza LINQ para encontrar la primera sesión cuyo SesionId coincida con el ID proporcionado.
            return _context.Sesiones.FirstOrDefault(s => s.SesionId == id);
        }

        // Método para agregar una nueva sesión a la base de datos.
        public void AddSesion(Sesion sesion)
        {
            // Agrega la sesión proporcionada al DbSet de Sesiones en el contexto de la base de datos.
            _context.Sesiones.Add(sesion);
            // Guarda los cambios en la base de datos.
            _context.SaveChanges();
        }

        // Método para actualizar una sesión existente en la base de datos.
        public void UpdateSesion(Sesion updatedSesion)
        {
            // Encuentra la sesión existente en la base de datos que coincida con el SesionId de la sesión actualizada.
            var existingSesion = _context.Sesiones.FirstOrDefault(s => s.SesionId == updatedSesion.SesionId);
            if (existingSesion != null)
            {
                // Actualiza los atributos de la sesión existente con los valores de la sesión actualizada.
                existingSesion.Horario = updatedSesion.Horario;
                existingSesion.PrecioEntrada = updatedSesion.PrecioEntrada;
                existingSesion.SalaId = updatedSesion.SalaId;
                existingSesion.Sala = updatedSesion.Sala;
                existingSesion.MovieId = updatedSesion.MovieId;
                existingSesion.Movie = updatedSesion.Movie;
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }

        // Método para eliminar una sesión de la base de datos por su ID.
        public void DeleteSesion(int id)
        {
            // Encuentra la sesión en la base de datos que coincida con el SesionId proporcionado.
            var sesionToDelete = _context.Sesiones.FirstOrDefault(s => s.SesionId == id);
            if (sesionToDelete != null)
            {
                // Elimina la sesión de la tabla de Sesiones en la base de datos.
                _context.Sesiones.Remove(sesionToDelete);
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }
    }
}
