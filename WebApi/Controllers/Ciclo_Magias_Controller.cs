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
    public class Ciclo_Magias_Controller : ControllerBase
    {
        private readonly Ciclo_Magias_Servico ciclo_Magias_Servico;

        public Ciclo_Magias_Controller()
        {
            ciclo_Magias_Servico = new Ciclo_Magias_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Ciclo_Magias> Ativos() => ciclo_Magias_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Ciclo_Magias entidade)
        {
            return ciclo_Magias_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Ciclo_Magias entidade)
        {
            return ciclo_Magias_Servico.Excluir(entidade);
        }
    }
}