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
    public class Ciclo_MagiasController : ControllerBase
    {
        private readonly Ciclo_Magia_Servico ciclo_Magias_Servico;

        public Ciclo_MagiasController()
        {
            ciclo_Magias_Servico = new Ciclo_Magia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Ciclo_Magia> Ativos() => ciclo_Magias_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Ciclo_Magia entidade)
        {
            return ciclo_Magias_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Ciclo_Magia entidade)
        {
            return ciclo_Magias_Servico.Excluir(entidade);
        }
    }
}