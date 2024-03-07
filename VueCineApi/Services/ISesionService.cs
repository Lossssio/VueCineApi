using VueCineApi.Models;
using System.Collections.Generic;
using VueCineApi.Dtos;

namespace VueCineApi.Services
{
    public interface ISesionService
    {
        List<Sesion> GetAllSesiones();
        Sesion GetSesionById(int id);
        void AddSesion(AddSesionDto sesion);
        void UpdateSesion(Sesion updatedSesion);
        void DeleteSesion(int id);
    }
}
