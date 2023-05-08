using AutoMapper;
using KakecoTalent.Application.Dtos.Response.General.KakecoSoft;
using KakecoTalent.Application.Interface.General;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;


namespace KakecoTalent.Application.UseCase.UseCases.Queries.GetAllQuery.General.KakecoSoft
{
    public class GetAllKakecoSoftHandler : IRequestHandler<GetAllKakecoSoftQuery, BaseResponse<IEnumerable<GetAllKakecoSoftResponseDto>>>
    {
        private readonly IKakecoSoftRepository _KakecoRepository;
        private readonly IMapper _mapper;
        public GetAllKakecoSoftHandler(IKakecoSoftRepository kakecoRepository, IMapper mapper)
        {
            _KakecoRepository = kakecoRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<IEnumerable<GetAllKakecoSoftResponseDto>>> Handle(GetAllKakecoSoftQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<IEnumerable<GetAllKakecoSoftResponseDto>>();
            try
            {
                var kakecoSoft = await _KakecoRepository.ListKakecoSoft();
                if (kakecoSoft != null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<IEnumerable<GetAllKakecoSoftResponseDto>>(kakecoSoft);
                    response.Mensaje = "Consulta Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}
