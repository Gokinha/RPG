using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using Aula09.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Arma_Controller : ControllerBase
    {
        private readonly Arma_Servico arma_Servico;

        public Arma_Controller()
        {
            arma_Servico = new Arma_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Arma> ListarTodosComEstoqueZerado()
        {
            return arma_Servico.ListarTodosComEstoqueZerado();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Arma entidade)
        {
            return arma_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Arma entidade)
        {
            return arma_Servico.Excluir(entidade);
        }
    }
}