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
    public class Ficha_Controller : ControllerBase
    {
        private readonly Ficha_Servico ficha_Servico;

        public Ficha_Controller()
        {
            ficha_Servico = new Ficha_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Ficha> Ativos() => ficha_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Ficha entidade)
        {
            return ficha_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Ficha entidade)
        {
            return ficha_Servico.Excluir(entidade);
        }
    }
}