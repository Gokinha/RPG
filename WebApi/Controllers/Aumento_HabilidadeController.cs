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
    public class Aumento_HabilidadeController : ControllerBase
    {
        private readonly Aumento_Habilidade_Servico aumento_Habilidade_Servico;

        public Aumento_HabilidadeController()
        {
            aumento_Habilidade_Servico = new Aumento_Habilidade_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Aumento_Habilidade> Ativos() => aumento_Habilidade_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Aumento_Habilidade entidade)
        {
            return aumento_Habilidade_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Aumento_Habilidade entidade)
        {
            return aumento_Habilidade_Servico.Excluir(entidade);
        }
    }
}