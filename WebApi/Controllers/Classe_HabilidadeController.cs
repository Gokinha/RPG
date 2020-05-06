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
    public class Classe_HabilidadeController : ControllerBase
    {
        private readonly Classe_Habilidade_Servico classe_Habilidade_Servico;

        public Classe_HabilidadeController()
        {
            classe_Habilidade_Servico = new Classe_Habilidade_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Classe_Habilidade> Ativos() => classe_Habilidade_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Classe_Habilidade entidade)
        {
            return classe_Habilidade_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Classe_Habilidade entidade)
        {
            return classe_Habilidade_Servico.Excluir(entidade);
        }
    }
}