using KakecoTalent.Application.Dtos.Response.General.KakecoSoft;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;

namespace KakecoTalent.Application.UseCase.UseCases.Queries.GetByIdQuery.General.KakecoSoft
{
    public class GetKakecoSoftByIdQuery : IRequest<BaseResponse<GetKakecoSoftByIdResponseDto>>
    {
        public int KakecoSoftId { get; set; }
    }
}
