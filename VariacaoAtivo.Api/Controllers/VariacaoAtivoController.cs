using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using VariacaoAtivo.Domain.Interface.Entities;
using VariacaoAtivo.Domain.Interface.Service;

namespace VariacaoAtivo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariacaoAtivoController : ControllerBase
    {
        IPesquisaAtivoService _pesquisaAtivoService;

        public VariacaoAtivoController(IPesquisaAtivoService pesquisaAtivoService) {

            _pesquisaAtivoService = pesquisaAtivoService;
        }


        [HttpGet]
        public async Task<ActionResult<List<IPesquisaAtivo>>> Get(string ativo, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                var quote = await _pesquisaAtivoService.GetAtivoPorPeriodo(ativo, dataInicial, dataFinal);
                return Ok(quote);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<IPesquisaAtivo>>> Get(string ativo)
        {
            try
            {
                var quote = await _pesquisaAtivoService.GetAtivoPorPeriodo("PETR4.SA",DateTime.Now.AddDays(-30), DateTime.Now);
                return Ok(quote);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

    }
}
