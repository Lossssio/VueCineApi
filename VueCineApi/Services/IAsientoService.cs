using VueCineApi.Models;
using System.Collections.Generic;
using VueCineApi.Dtos;
namespace VueCineApi.Services
{
    public interface IAsientoService
    {
        List<Asiento> GetAllAsientos();
        Asiento GetAsientoById(int id);
        void AddAsiento(AddAsientoDto asiento);
        void UpdateAsiento(Asiento updatedAsiento);
        void DeleteAsiento(int id);
    }
}
