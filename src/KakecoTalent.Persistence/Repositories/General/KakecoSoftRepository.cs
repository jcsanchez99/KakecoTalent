using Dapper;
using KakecoTalent.Application.Interface.General;
using KakecoTalent.Domain.Entities.General;
using KakecoTalent.Persistence.Context;
using System.Data;

namespace KakecoTalent.Persistence.Repositories.General
{
    public class KakecoSoftRepository : IKakecoSoftRepository
    {
        private readonly ApplicationDbContext _context;
        public KakecoSoftRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<KakecoSoft>> ListKakecoSoft()
        {
            using var connection = _context.CreateConnection;
            var query = "General.uspKakecoSoftList";
            var kakecosoft = await connection.QueryAsync<KakecoSoft>(query, commandType: CommandType.StoredProcedure);
            return kakecosoft;
        }
        public async Task<KakecoSoft> KakecoSoftById(int kakecosoftId)
        {
            using var connection = _context.CreateConnection;
            var query = "General.uspKakecoSoftById";
            var parameters = new DynamicParameters();
            parameters.Add("KakecoSoftId", kakecosoftId);
            var KakecoSoftEntity = await connection
                .QueryFirstOrDefaultAsync<KakecoSoft>(query, param: parameters, commandType: CommandType.StoredProcedure);
            return KakecoSoftEntity;
        }

        public async Task<bool> KakecoSoftRegister(KakecoSoft kakecoSoft)
        {
            using var connection = _context.CreateConnection;
            var query = "General.uspKakecoSoftRegister";
            var parameters = new DynamicParameters();
            parameters.Add("Codigo", kakecoSoft.Codigo);
            parameters.Add("Nombre", kakecoSoft.Nombre);
            parameters.Add("Direccion", kakecoSoft.Direccion);
            parameters.Add("Telefono", kakecoSoft.Telefono);
            parameters.Add("Email", kakecoSoft.Email);
            parameters.Add("Activo", 1);
            var recordAffected = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            return recordAffected > 0;
        }

        public async Task<bool> KakecoSoftEdit(KakecoSoft kakecoSoft)
        {
            using var connection = _context.CreateConnection;
            var query = "General.uspKakecoSoftEdit";
            var parameters = new DynamicParameters();
            parameters.Add("Id", kakecoSoft.Id);
            parameters.Add("Codigo", kakecoSoft.Codigo);
            parameters.Add("Nombre", kakecoSoft.Nombre);
            parameters.Add("Direccion", kakecoSoft.Direccion);
            parameters.Add("Telefono", kakecoSoft.Telefono);
            parameters.Add("Email", kakecoSoft.Email);
            parameters.Add("Activo", 1);
            var recordAffected = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            return recordAffected > 0;
        }

        public async Task<bool> KakecoSoftDelete(int kakecosoftId)
        {
            using var connection = _context.CreateConnection;
            var query = "General.uspKakecoSoftDelete";
            var parameters = new DynamicParameters();
            parameters.Add("Id", kakecosoftId);
            var recordAffected = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
            return recordAffected > 0;
        }
    }
}
