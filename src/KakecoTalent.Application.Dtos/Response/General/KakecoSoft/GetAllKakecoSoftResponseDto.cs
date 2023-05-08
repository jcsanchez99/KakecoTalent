namespace KakecoTalent.Application.Dtos.Response.General.KakecoSoft
{
    public class GetAllKakecoSoftResponseDto
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public bool Activo { get; set; }
        public string? StateKakecoSoft { get; set; }
    }
}
