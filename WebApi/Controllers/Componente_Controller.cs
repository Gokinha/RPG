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
    public class Componente_Controller : ControllerBase
    {
        private readonly Componente_Servico componente_Servico;

        public Componente_Controller()
        {
            componente_Servico = new Componente_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Componente> Ativos() => componente_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Componente entidade)
        {
            return componente_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Componente entidade)
        {
            return componente_Servico.Excluir(entidade);
        }
    }
}