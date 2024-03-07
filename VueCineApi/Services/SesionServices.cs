using VueCineApi.Data;
using VueCineApi.Dtos;
using VueCineApi.Models;

namespace VueCineApi.Services
{
        public class SesionServices : ISesionService
        {
            private readonly SesionData _sesionData;

            public SesionServices(SesionData sesionData)
            {
                _sesionData = sesionData;
            }

            public List<Sesion> GetAllSesiones()
            {
                return _sesionData.GetAllSesiones();
            }

            public Sesion GetSesionById(int id)
            {
                return _sesionData.GetSesionById(id);
            }

            public void AddSesion(AddSesionDto sesionDto)
            {
                var sesion = new Sesion()
                {
                    Horario = sesionDto.Horario,
                    SesionId = sesionDto.SesionId
                };
                _sesionData.AddSesion(sesion);
            }

            public void UpdateSesion(Sesion updateSesion)
            {
                _sesionData.UpdateSesion(updateSesion);
            }

            public void DeleteSesion(int id)
            {
                _sesionData.DeleteSesion(id);
            }
        }
    }


