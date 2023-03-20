using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using VariacaoAtivo.Domain.Interface.Entities;
using VariacaoAtivo.Domain.Interface.Service;
using VariacaoAtivo.Service;
using VariacaoAtivo.Service.HttpService.Refit;

namespace VariacaoAtivo.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(IServiceCollection services)
        {
            services    
                .AddRefitClient<IYahooFinanceApi>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(@"https://query2.finance.yahoo.com/v8"));

            services.AddScoped<IPesquisaAtivoService, PesquisaAtivoService>();

            return services;
        }

    }
}

