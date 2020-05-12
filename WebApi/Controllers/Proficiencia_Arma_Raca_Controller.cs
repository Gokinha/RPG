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
    public class Proficiencia_Arma_Raca_Controller : ControllerBase
    {
        private readonly Proficiencia_Arma_Raca_Servico proficiencia_Arma_Raca_Servico;

        public Proficiencia_Arma_Raca_Controller()
        {
            proficiencia_Arma_Raca_Servico = new Proficiencia_Arma_Raca_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Proficiencia_Arma_Raca> Ativos() => proficiencia_Arma_Raca_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Proficiencia_Arma_Raca entidade)
        {
            return proficiencia_Arma_Raca_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Proficiencia_Arma_Raca entidade)
        {
            return proficiencia_Arma_Raca_Servico.Excluir(entidade);
        }
    }
}