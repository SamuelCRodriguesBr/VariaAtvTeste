using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using VariacaoAtivo.Domain.Interface.Entities;
using VariacaoAtivo.Domain.Interface.Service;
using VariacaoAtivo.Service.HttpService.Refit;
using Newtonsoft.Json;

namespace VariacaoAtivo.Service
{
    public class PesquisaAtivoService : IPesquisaAtivoService
    {
        private readonly IYahooFinanceApi _yahooFinanceApi;

        public PesquisaAtivoService(IYahooFinanceApi yahooFinanceApi)
        {
            _yahooFinanceApi = yahooFinanceApi;
        }
        public Task<List<IPesquisaAtivo>> GetAtivoPorPeriodo(string ativo, DateTime dataInicial, DateTime dataFinal)
        {
            string strDtInicio = ((DateTimeOffset)dataInicial).ToUnixTimeSeconds().ToString();
            string strDtFim = ((DateTimeOffset)dataInicial).ToUnixTimeSeconds().ToString();

            var json = _yahooFinanceApi.GetAtivoPorPeriodoAsync(ativo, strDtInicio, strDtFim).Result;

            var dados = JsonConvert.DeserializeObject<innerCHart>(json);

            var retorno = new List<IPesquisaAtivo>();

            


            return null;
        }

        class innerCHart { 
            public string chart { get; set; }


        }

    }
}
