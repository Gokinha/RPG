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
    public class ComponenteController : ControllerBase
    {
        private readonly Componente_Servico componente_Servico;

        public ComponenteController()
        {
            componente_Servico = new Componente_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Componente> Ativos() => componente_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Componente entidade)
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