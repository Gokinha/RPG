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
    public class Caracteristica_Raca_Controller : ControllerBase
    {
        private readonly Caracteristica_raca_Servico caracteristica_Raca_Servico;

        public Caracteristica_Raca_Controller()
        {
            caracteristica_Raca_Servico = new Caracteristica_raca_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Caracteristica_Raca> Ativos() => caracteristica_Raca_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Caracteristica_Raca entidade)
        {
            return caracteristica_Raca_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Caracteristica_Raca entidade)
        {
            return caracteristica_Raca_Servico.Excluir(entidade);
        }
    }
}