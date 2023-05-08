using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;

namespace KakecoTalent.Application.UseCase.UseCases.Commands.CreateCommand.General.KakecoSoft
{
    public class CreateKakecoSoftCommand : IRequest<BaseResponse<bool>>
    {
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}
