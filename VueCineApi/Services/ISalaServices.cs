using VueCineApi.Models;
using System.Collections.Generic;
using VueCineApi.Dtos;

namespace VueCineApi.Services
{
    public interface ISalaServices
    {
        List<Sala> GetAllSalas();
        Sala GetSalaById(int id);
        void AddSala(AddSalaDto sala);
        void UpdateSala(Sala updatedSala);
        void DeleteSala(int id);
    }
}
