using VueCineApi.Data;
using VueCineApi.Dtos;
using VueCineApi.Models;

namespace VueCineApi.Services
{

    public class AsientoServices : IAsientoService
    {
        private readonly AsientoData _asientoData;

        public AsientoServices(AsientoData asientoData)
        {
            _asientoData = asientoData;
        }

        public List<Asiento> GetAllAsientos()
        {
            return _asientoData.GetAllAsientos();
        }

        public Asiento GetAsientoById(int id)
        {
            return _asientoData.GetAsientoById(id);
        }

        public void AddAsiento(AddAsientoDto asientoDto)
        {
            var asiento = new Asiento()
            {
                Horario = asientoDto.Horario,
                SalaId = asientoDto.SalaId,
                Estado = "Libre",
                Tipo = asientoDto.Tipo
                
            };
            _asientoData.AddAsiento(asiento);
        }

        public void UpdateAsiento(Asiento updateAsiento)
        {
            _asientoData.UpdateAsiento(updateAsiento);
        }

        public void DeleteAsiento(int id)
        {
            _asientoData.DeleteAsiento(id);
        }
    }
}


