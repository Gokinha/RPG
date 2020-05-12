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
    public class Habilidade_Controller : ControllerBase
    {
        private readonly Habilidade_Servico habilidade_Servico;

        public Habilidade_Controller()
        {
            habilidade_Servico = new Habilidade_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Habilidade> Ativos() => habilidade_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Habilidade entidade)
        {
            return habilidade_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Habilidade entidade)
        {
            return habilidade_Servico.Excluir(entidade);
        }
    }
}