using KakecoTalent.Application.Dtos.Response.General.KakecoSoft;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;

namespace KakecoTalent.Application.UseCase.UseCases.Queries.GetAllQuery.General.KakecoSoft
{
    public class GetAllKakecoSoftQuery : IRequest<BaseResponse<IEnumerable<GetAllKakecoSoftResponseDto>>>
    {

    }
}
