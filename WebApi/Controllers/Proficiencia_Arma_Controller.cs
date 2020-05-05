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
    public class Proficiencia_Arma_Controller : ControllerBase
    {
        private readonly Proficiencia_Arma_Servico proficiencia_Arma_Servico;

        public Proficiencia_Arma_Controller()
        {
            proficiencia_Arma_Servico = new Proficiencia_Arma_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Proficiencia_Arma> Ativos() => proficiencia_Arma_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Proficiencia_Arma entidade)
        {
            return proficiencia_Arma_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Proficiencia_Arma entidade)
        {
            return proficiencia_Arma_Servico.Excluir(entidade);
        }
    }
}