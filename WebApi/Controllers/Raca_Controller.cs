using System;
using System.Collections.Generic;
using Aula09.Dominio;
using Microsoft.AspNetCore.Mvc;
using Aula09.Comum.NotificationPattern;
using Aula09.Servico;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Raca_Controller : ControllerBase
    {
        private readonly Raca_Servico raca_Servico;

        public Raca_Controller()
        {
            raca_Servico = new Raca_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Raca> Ativos() => raca_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Raca entidade)
        {
            return raca_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Raca entidade)
        {
            return raca_Servico.Excluir(entidade);
        }
    }
}