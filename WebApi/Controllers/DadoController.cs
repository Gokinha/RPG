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
    public class DadoController : ControllerBase
    {
        private readonly Dado_Servico dado_Servico;

        public DadoController()
        {
            dado_Servico = new Dado_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Dado> Ativos() => dado_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Dado entidade)
        {
            return dado_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Dado entidade)
        {
            return dado_Servico.Excluir(entidade);
        }
    }
}