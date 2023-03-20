using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariacaoAtivo.Domain.Interface.Entities
{
    public interface IPesquisaAtivo
    {
        string Ativo { get; set; }
        DateTime Data { get; set; }
        double Variacao { get; set; }
        string Json { get; set; }
    }
}
