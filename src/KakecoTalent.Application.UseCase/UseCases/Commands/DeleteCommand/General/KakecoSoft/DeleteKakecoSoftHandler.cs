using AutoMapper;
using KakecoTalent.Application.Interface.General;
using KakecoTalent.Application.UseCase.Commons.Bases;
using MediatR;

namespace KakecoTalent.Application.UseCase.UseCases.Commands.DeleteCommand.General.KakecoSoft
{
    public class DeleteKakecoSoftHandler : IRequestHandler<DeleteKakecoSoftCommand, BaseResponse<bool>>
    {
        private readonly IKakecoSoftRepository _KakecoRepository;
        private readonly IMapper _mapper;
        public DeleteKakecoSoftHandler(IKakecoSoftRepository kakecoRepository, IMapper mapper)
        {
            _KakecoRepository = kakecoRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(DeleteKakecoSoftCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();
            try
            {
                response.Data = await _KakecoRepository.KakecoSoftDelete(request.Id);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Mensaje = "Eliminación Exitosa!!!";
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
