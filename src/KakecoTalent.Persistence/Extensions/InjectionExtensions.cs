using KakecoTalent.Application.Interface.General;
using KakecoTalent.Persistence.Context;
using KakecoTalent.Persistence.Repositories.General;
using Microsoft.Extensions.DependencyInjection;

namespace KakecoTalent.Persistence.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            services.AddSingleton<ApplicationDbContext>();
            services.AddScoped<IKakecoSoftRepository, KakecoSoftRepository>();
            return services;
        }
    }
}
