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
    public class AtributoController : ControllerBase
    {
        private readonly Atributo_Servico atributo_Servico;

        public AtributoController()
        {
            atributo_Servico = new Atributo_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Atributo> Ativos() => atributo_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Atributo entidade)
        {
            return atributo_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Atributo entidade)
        {
            return atributo_Servico.Excluir(entidade);
        }
    }
}