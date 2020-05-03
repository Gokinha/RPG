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
    public class Arma_Classe_Controller : ControllerBase
    {
        private readonly Arma_Classe_Servico arma_classe_Servico;

        public Arma_Classe_Controller()
        {
            arma_classe_Servico = new Arma_Classe_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Arma_Classe> Ativos() => arma_classe_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Arma_Classe entidade)
        {
            return arma_classe_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Arma_Classe entidade)
        {
            return arma_classe_Servico.Excluir(entidade);
        }
    }
}