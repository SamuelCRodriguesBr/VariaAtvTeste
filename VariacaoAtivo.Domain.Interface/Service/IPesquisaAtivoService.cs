using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariacaoAtivo.Domain.Interface.Entities;

namespace VariacaoAtivo.Domain.Interface.Service
{
    public interface IPesquisaAtivoService
    {
        public Task<List<IPesquisaAtivo>> GetAtivoPorPeriodo(string ativo, DateTime dataInicial, DateTime dataFinal);
    }
}
