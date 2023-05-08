using AutoMapper;
using KakecoTalent.Application.Interface.General;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;
using Entity = KakecoTalent.Domain.Entities.General;

namespace KakecoTalent.Application.UseCase.UseCases.Commands.CreateCommand.General.KakecoSoft
{
    public class CreateKakecoSoftHandler : IRequestHandler<CreateKakecoSoftCommand, BaseResponse<bool>>
    {
        private readonly IKakecoSoftRepository _KakecoRepository;
        private readonly IMapper _mapper;
        public CreateKakecoSoftHandler(IKakecoSoftRepository kakecoRepository, IMapper mapper)
        {
            _KakecoRepository = kakecoRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(CreateKakecoSoftCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var KakecoSoft = _mapper.Map<Entity.KakecoSoft>(request);
                response.Data = await _KakecoRepository.KakecoSoftRegister(KakecoSoft);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Mensaje = "Se registro correctamente.";
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
