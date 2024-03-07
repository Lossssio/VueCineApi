using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Controllers;

namespace VueCineApi.Data
{
    public class AsientoData
    {
        // Declara una variable privada para acceder al contexto de la base de datos.
        private readonly ApplicationDbContext _context;

        // Constructor que recibe el contexto de la base de datos y lo asigna a la variable privada _context.
        public AsientoData(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los asientos de la base de datos.
        public List<Asiento> GetAllAsientos()
        {
            // Utiliza LINQ para obtener todos los asientos y convertirlos en una lista.
            return _context.Asientos.ToList();
        }

        // Método para obtener un asiento por su ID.
        public Asiento GetAsientoById(int id)
        {
            // Utiliza LINQ para encontrar el primer asiento cuyo AsientoId coincida con el ID proporcionado.
            return _context.Asientos.FirstOrDefault(a => a.AsientoId == id);
        }

        // Método para agregar un nuevo asiento a la base de datos.
        public void AddAsiento(Asiento asiento)
        {
            // Agrega el asiento proporcionado al DbSet de Asientos en el contexto de la base de datos.
            _context.Asientos.Add(asiento);
            // Guarda los cambios en la base de datos.
            _context.SaveChanges();
        }

        // Método para actualizar un asiento existente en la base de datos.
        public void UpdateAsiento(Asiento updatedAsiento)
        {
            // Encuentra el asiento existente en la base de datos que coincida con el AsientoId del asiento actualizado.
            var existingAsiento = _context.Asientos.FirstOrDefault(a => a.AsientoId == updatedAsiento.AsientoId);
            if (existingAsiento != null)
            {
                // Actualiza los atributos del asiento existente con los valores del asiento actualizado.
                existingAsiento.NumAsientos = updatedAsiento.NumAsientos;
                existingAsiento.Horario = updatedAsiento.Horario;
                existingAsiento.Estado = updatedAsiento.Estado;
                existingAsiento.Tipo = updatedAsiento.Tipo;
                existingAsiento.SalaId = updatedAsiento.SalaId;
                existingAsiento.Sala = updatedAsiento.Sala;
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }

        // Método para eliminar un asiento de la base de datos por su ID.
        public void DeleteAsiento(int id)
        {
            // Encuentra el asiento en la base de datos que coincida con el AsientoId proporcionado.
            var asientoToDelete = _context.Asientos.FirstOrDefault(a => a.AsientoId == id);
            if (asientoToDelete != null)
            {
                // Elimina el asiento de la tabla de Asientos en la base de datos.
                _context.Asientos.Remove(asientoToDelete);
                // Guarda los cambios en la base de datos.
                _context.SaveChanges();
            }
        }
    }
}
