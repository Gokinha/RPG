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
    public class Classe_Controller : ControllerBase
    {
        private readonly Classe_Servico classe_Servico;

        public Classe_Controller()
        {
            classe_Servico = new Classe_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Classe> Ativos() => classe_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Classe entidade)
        {
            return classe_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Classe entidade)
        {
            return classe_Servico.Excluir(entidade);
        }
    }
}