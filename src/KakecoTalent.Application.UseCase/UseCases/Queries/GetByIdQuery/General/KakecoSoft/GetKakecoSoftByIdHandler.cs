using AutoMapper;
using KakecoTalent.Application.Dtos.Response.General.KakecoSoft;
using KakecoTalent.Application.Interface.General;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;

namespace KakecoTalent.Application.UseCase.UseCases.Queries.GetByIdQuery.General.KakecoSoft
{
    public class GetKakecoSoftByIdHandler : IRequestHandler<GetKakecoSoftByIdQuery, BaseResponse<GetKakecoSoftByIdResponseDto>>
    {
        private readonly IKakecoSoftRepository _KakecoRepository;
        private readonly IMapper _mapper;

        public GetKakecoSoftByIdHandler(IKakecoSoftRepository kakecoRepository, IMapper mapper)
        {
            _KakecoRepository = kakecoRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<GetKakecoSoftByIdResponseDto>> Handle(GetKakecoSoftByIdQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<GetKakecoSoftByIdResponseDto>();
            try
            {
                var KakecoSoftEntity = await _KakecoRepository.KakecoSoftById(request.KakecoSoftId);
                if (KakecoSoftEntity == null)
                {
                    response.IsSuccess = false;
                    response.Mensaje = "No se encontraron registros.";
                    return response;
                }
                response.IsSuccess = true;
                response.Data = _mapper.Map<GetKakecoSoftByIdResponseDto>(KakecoSoftEntity);
                response.Mensaje = "Consulta Exitosa.";


            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}
