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
    public class Arma_Inventario_Controller : ControllerBase
    {
        private readonly Arma_Inventario_Servico arma_Inventario_Servico;

        public Arma_Inventario_Controller()
        {
            arma_Inventario_Servico = new Arma_Inventario_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Arma_Inventario> ListarTodosComEstoqueZerado()
        {
            return arma_Inventario_Servico.ListarTodosComEstoqueZerado();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Arma_Inventario entidade)
        {
            return arma_Inventario_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Arma_Inventario entidade)
        {
            return arma_Inventario_Servico.Excluir(entidade);
        }
    }
}