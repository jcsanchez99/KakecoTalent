using AutoMapper;
using KakecoTalent.Application.Dtos.Response.General.KakecoSoft;
using KakecoTalent.Application.UseCase.UseCases.Commands.CreateCommand.General.KakecoSoft;
using KakecoTalent.Application.UseCase.UseCases.Commands.UpdateCommand.General.KakecoSoft;
using Entity = KakecoTalent.Domain.Entities.General;

namespace KakecoTalent.Application.UseCase.Mapping.General.KakecoSoft
{
    public class KakecoSoftMappingProfile : Profile
    {
        public KakecoSoftMappingProfile()
        {
            CreateMap<Entity.KakecoSoft, GetAllKakecoSoftResponseDto>()
                .ForMember(x => x.StateKakecoSoft, x => x.MapFrom(y => y.Activo == true ? "ACTIVO" : "INACTIVO"))
                .ReverseMap();

            CreateMap<Entity.KakecoSoft, GetKakecoSoftByIdResponseDto>()
               .ReverseMap();

            CreateMap<CreateKakecoSoftCommand, Entity.KakecoSoft>();
            CreateMap<UpdateKakecoSoftCommand, Entity.KakecoSoft>();


        }
    }
}
