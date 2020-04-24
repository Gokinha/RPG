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
    public class Moeda_Controller : ControllerBase
    {
        private readonly Moeda_Servico moeda_Servico;

        public Moeda_Controller()
        {
            moeda_Servico = new Moeda_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Moeda> Ativos() => moeda_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Moeda entidade)
        {
            return moeda_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Moeda entidade)
        {
            return moeda_Servico.Excluir(entidade);
        }
    }
}