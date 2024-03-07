namespace VueCineApi.Dtos
{
    public class AddSesionDto
    {
        public int? SesionId { get; set; }
        public DateTime Horario { get; set; }
        public decimal PrecioEntrada { get; set; }
    }
}
