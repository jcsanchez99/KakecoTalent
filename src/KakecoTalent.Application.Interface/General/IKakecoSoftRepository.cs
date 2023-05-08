using KakecoTalent.Domain.Entities.General;

namespace KakecoTalent.Application.Interface.General
{
    public interface IKakecoSoftRepository
    {
        Task<IEnumerable<KakecoSoft>> ListKakecoSoft();
        Task<KakecoSoft> KakecoSoftById(int kakecosoftId);
        Task<bool> KakecoSoftRegister(KakecoSoft kakecoSoft);
        Task<bool> KakecoSoftEdit(KakecoSoft kakecoSoft);
        Task<bool> KakecoSoftDelete(int kakecosoftId);
    }
}
