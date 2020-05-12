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
    public class Caracteristicas_Controller : ControllerBase
    {
        private readonly Caracteristicas_Servico caracteristicas_Servico;

        public Caracteristicas_Controller()
        {
            caracteristicas_Servico = new Caracteristicas_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Caracteristicas> Ativos() => caracteristicas_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Caracteristicas entidade)
        {
            return caracteristicas_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Caracteristicas entidade)
        {
            return caracteristicas_Servico.Excluir(entidade);
        }
    }
}