using VueCineApi.Data;
using VueCineApi.Dtos;
using VueCineApi.Models;

namespace VueCineApi.Services
{

        public class SalaServices : ISalaServices
        {
            private readonly SalaData _salaData;

            public SalaServices(SalaData salaData)
            {
                _salaData = salaData;
            }

            public List<Sala> GetAllSalas()
            {
                return _salaData.GetAllSalas();
            }

            public Sala GetSalaById(int id)
            {
                return _salaData.GetSalaById(id);
            }

            public void AddSala(AddSalaDto salaDto)
            {
                var sala = new Sala()
                {
                    Horario = salaDto.Horario,
                    SalaId = salaDto.SalaId,
                    Estado = salaDto.Estado

                };
                _salaData.AddSala(sala);
            }

            public void UpdateSala(Sala updateSala)
            {
                _salaData.UpdateSala(updateSala);
            }

            public void DeleteSala(int id)
            {
                _salaData.DeleteSala(id);
            }
        }
    }

