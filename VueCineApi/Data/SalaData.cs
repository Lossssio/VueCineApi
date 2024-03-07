using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Controllers;

namespace VueCineApi.Data
{
    public class SalaData
    {
        // Declara una variable privada para acceder al contexto de la base de datos.
        private readonly ApplicationDbContext _context;

        // Constructor que recibe el contexto de la base de datos y lo asigna a la variable privada _context.
        public SalaData(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método para obtener todas las salas de la base de datos.
        public List<Sala> GetAllSalas()
        {
            // Utiliza LINQ para obtener todas las salas y convertirlas en una lista.
            return _context.Salas.ToList();
        }

        // Método para obtener una sala por su ID.
        public Sala GetSalaById(int id)
        {
            // Utiliza LINQ para encontrar la primera sala cuyo SalaId coincida con el ID proporcionado.
            return _context.Salas.FirstOrDefault(s => s.SalaId == id);
        }

        // Método para agregar una nueva sala a la base de datos.
        public void AddSala(Sala sala)
        {
            // Agrega la sala proporcionada al DbSet de Salas en el contexto de la base de datos.
            _context.Salas.Add(sala);
            // Guarda los cambios en la base de datos.
            _context.SaveChanges();
        }

        // Método para actualizar una sala existente en la base de datos.
        public void UpdateSala(Sala updatedSala)
        {
            // Encuentra la sala existente en la base de datos que coincida con el SalaId de la sala actualizada.
            var existingSala = _context.Salas.FirstOrDefault(s => s.SalaId == updatedSala.SalaId);
            if (existingSala != null)
            {
                // Actualiza los atributos de la sala existente con los valores de la sala actualizada.
                existingSala.Capacidad = updatedSala.Capacidad;
                existingSala.Estado = updatedSala.Estado;
                existingSala.Horario = updatedSala.Horario;
                existingSala.CineId = updatedSala.CineId;
                existingSala.Asientos = updatedSala.Asientos;
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }

        // Método para eliminar una sala de la base de datos por su ID.
        public void DeleteSala(int id)
        {
            // Encuentra la sala en la base de datos que coincida con el SalaId proporcionado.
            var salaToDelete = _context.Salas.FirstOrDefault(s => s.SalaId == id);
            if (salaToDelete != null)
            {
                // Elimina la sala de la tabla de Salas en la base de datos.
                _context.Salas.Remove(salaToDelete);
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }
    }
}
