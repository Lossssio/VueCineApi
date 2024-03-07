using VueCineApi.Models;
using System.Collections.Generic;
using VueCineApi.Dtos;

namespace VueCineApi.Services
{
    public interface ICineServices
    {
        List<Cine> GetAllCines();
        Cine GetCineById(int id);
        void AddCine(AddCineDto cine);
        void UpdateCine(Cine updatedCine);
        void DeleteCine(int id);
    }
}
