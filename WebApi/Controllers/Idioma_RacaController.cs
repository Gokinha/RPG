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
    public class Idioma_RacaController : ControllerBase
    {
        private readonly Idioma_Raca_Servico idioma_Raca_Servico;

        public Idioma_RacaController()
        {
            idioma_Raca_Servico = new Idioma_Raca_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Idioma_Raca> Ativos() => idioma_Raca_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Idioma_Raca entidade)
        {
            return idioma_Raca_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Idioma_Raca entidade)
        {
            return idioma_Raca_Servico.Excluir(entidade);
        }
    }
}