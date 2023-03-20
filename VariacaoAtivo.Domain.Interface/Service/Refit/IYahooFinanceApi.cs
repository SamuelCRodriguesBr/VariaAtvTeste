using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariacaoAtivo.Service.HttpService.Refit
{
    internal interface IYahooFinanceApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="versao">Versão da Api</param>
        /// <param name="ativo">Sigla do Ativo listado na B3 (ex:PETR4,BBAS3,...)</param>
        /// <param name="dataInicio">data de inicio do periodo em formato unix timestamp</param>
        /// <param name="dataFim">data de fim do periodo em formato unix timestamp</param>
        /// <returns></returns>
        [Get("/{versao}/quote/{ativo}/history?period1={dataInicio}&period2={dataFim}&interval=1d")]
        Task<string> GetAtivoPorPeriodoAsync(string versao, string ativo, string dataInicio, string dataFim);
    }
}
