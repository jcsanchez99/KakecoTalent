using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;

namespace KakecoTalent.Application.UseCase.UseCases.Commands.DeleteCommand.General.KakecoSoft
{
    public class DeleteKakecoSoftCommand : IRequest<BaseResponse<bool>>
    {
        public int Id { get; set; }
    }
}
