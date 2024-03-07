using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Controllers;

namespace VueCineApi.Data
{
    public class CineData
    {
        // Declara una variable privada para acceder al contexto de la base de datos.
        private readonly ApplicationDbContext _context;

        // Constructor que recibe el contexto de la base de datos y lo asigna a la variable privada _context.
        public CineData(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los cines de la base de datos.
        public List<Cine> GetAllCines()
        {
            // Utiliza LINQ para obtener todos los cines y convertirlos en una lista.
            return _context.Cines.ToList();
        }

        // Método para obtener un cine por su ID.
        public Cine GetCineById(int id)
        {
            // Utiliza LINQ para encontrar el primer cine cuyo CineId coincida con el ID proporcionado.
            return _context.Cines.FirstOrDefault(c => c.CineId == id);
        }

        // Método para agregar un nuevo cine a la base de datos.
        public void AddCine(Cine cine)
        {
            // Agrega el cine proporcionado al DbSet de Cines en el contexto de la base de datos.
            _context.Cines.Add(cine);
            // Guarda los cambios en la base de datos.
            _context.SaveChanges();
        }

        // Método para actualizar un cine existente en la base de datos.
        public void UpdateCine(Cine updatedCine)
        {
            // Encuentra el cine existente en la base de datos que coincida con el CineId del cine actualizado.
            var existingCine = _context.Cines.FirstOrDefault(c => c.CineId == updatedCine.CineId);
            if (existingCine != null)
            {
                // Actualiza los atributos del cine existente con los valores del cine actualizado.
                existingCine.Nombre = updatedCine.Nombre;
                existingCine.Horario = updatedCine.Horario;
                existingCine.NumSalas = updatedCine.NumSalas;
                existingCine.Salas = updatedCine.Salas;
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }

        // Método para eliminar un cine de la base de datos por su ID.
        public void DeleteCine(int id)
        {
            // Encuentra el cine en la base de datos que coincida con el CineId proporcionado.
            var cineToDelete = _context.Cines.FirstOrDefault(c => c.CineId == id);
            if (cineToDelete != null)
            {
                // Elimina el cine de la tabla de Cines en la base de datos.
                _context.Cines.Remove(cineToDelete);
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }
    }
}
