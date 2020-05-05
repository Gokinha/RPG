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
    public class Arma_Propriedade_Arma_Controller : ControllerBase
    {
        private readonly Arma_Propriedade_Arma_Servico arma_Propriedade_Arma_Servico;

        public Arma_Propriedade_Arma_Controller()
        {
            arma_Propriedade_Arma_Servico = new Arma_Propriedade_Arma_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Arma_Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return arma_Propriedade_Arma_Servico.ListarTodosComEstoqueZerado();
        }

        [HttpPost("Salvar")]
        public string Salvar(Arma_Propriedade_Arma entidade)
        {
            return arma_Propriedade_Arma_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Arma_Propriedade_Arma entidade)
        {
            return arma_Propriedade_Arma_Servico.Excluir(entidade);
        }
    }
}