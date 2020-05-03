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
    public class Espaco_Magias_Controller : ControllerBase
    {
        private readonly Espaco_Magias_Servico espaco_Magias_Servico;

        public Espaco_Magias_Controller()
        {
            espaco_Magias_Servico = new Espaco_Magias_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Espaco_Magias> Ativos() => espaco_Magias_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Espaco_Magias entidade)
        {
            return espaco_Magias_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Espaco_Magias entidade)
        {
            return espaco_Magias_Servico.Excluir(entidade);
        }
    }
}