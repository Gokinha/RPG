using System;
using System.Collections.Generic;
using Aula09.Dominio;
using Microsoft.AspNetCore.Mvc;
using Aula09.Comum.NotificationPattern;
using Aula09.Servico;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Nivel_ClasseController : ControllerBase
    {
        private readonly Nivel_Classe_Servico nivelClasse_Servico;

        public Nivel_ClasseController()
        {
            nivelClasse_Servico = new Nivel_Classe_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Nivel_Classe> ListarTodosComEstoqueZerado()
        {
            return nivelClasse_Servico.ListarTodosComEstoqueZerado();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Nivel_Classe entidade)
        {
            return nivelClasse_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Nivel_Classe entidade)
        {
            return nivelClasse_Servico.Excluir(entidade);
        }

    }
}