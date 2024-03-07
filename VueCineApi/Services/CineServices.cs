using VueCineApi.Data;
using VueCineApi.Dtos;
using VueCineApi.Models;

namespace VueCineApi.Services
{


        public class CineServices : ICineServices
        {
            private readonly CineData _cineData;

            public CineServices(CineData cineData)
            {
            _cineData = cineData;
            }

            public List<Cine> GetAllCines()
            {
                return _cineData.GetAllCines();
            }

            public Cine GetCineById(int id)
            {
                return _cineData.GetCineById(id);
            }

            public void AddCine(AddCineDto cineDto)
            {
                var cine = new Cine()
                {
                    Horario = cineDto.Horario,
                    CineId = cineDto.CineId
                };
                _cineData.AddCine(cine);
            }

            public void UpdateCine(Cine updateCine)
            {
                _cineData.UpdateCine(updateCine);
            }

            public void DeleteCine(int id)
            {
                _cineData.DeleteCine(id);
            }
        }
    }



