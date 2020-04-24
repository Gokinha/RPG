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
    public class Nivel_Controller : ControllerBase
    {
        private readonly Nivel_Servico nivel_Servico;

        public Nivel_Controller()
        {
            nivel_Servico = new Nivel_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Nivel> Ativos() => nivel_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Nivel entidade)
        {
            return nivel_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Nivel entidade)
        {
            return nivel_Servico.Excluir(entidade);
        }
    }
}