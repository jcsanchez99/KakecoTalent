using AutoMapper;
using KakecoTalent.Application.Interface.General;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;
using Entity = KakecoTalent.Domain.Entities.General;

namespace KakecoTalent.Application.UseCase.UseCases.Commands.UpdateCommand.General.KakecoSoft
{
    public class UpdateKakecoSoftHandler : IRequestHandler<UpdateKakecoSoftCommand, BaseResponse<bool>>
    {
        private readonly IKakecoSoftRepository _KakecoRepository;
        private readonly IMapper _mapper;
        public UpdateKakecoSoftHandler(IKakecoSoftRepository kakecoRepository, IMapper mapper)
        {
            _KakecoRepository = kakecoRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<bool>> Handle(UpdateKakecoSoftCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var KakecoSoft = _mapper.Map<Entity.KakecoSoft>(request);
                response.Data = await _KakecoRepository.KakecoSoftEdit(KakecoSoft);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Mensaje = "Actualización Exitosa!!!";
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
