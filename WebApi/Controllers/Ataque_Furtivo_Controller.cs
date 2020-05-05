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
    public class Ataque_Furtivo_Controller : ControllerBase
    {
        private readonly Ataque_Furtivo_Servico ataque_Furtivo_Servico;

        public Ataque_Furtivo_Controller()
        {
            ataque_Furtivo_Servico = new Ataque_Furtivo_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Ataque_Furtivo> Ativos() => ataque_Furtivo_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Ataque_Furtivo entidade)
        {
            return ataque_Furtivo_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Ataque_Furtivo entidade)
        {
            return ataque_Furtivo_Servico.Excluir(entidade);
        }
    }
}