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
    public class Ficha_Atributo_Controller : ControllerBase
    {
        private readonly Ficha_Atributo_Servico ficha_Atributo_Servico;

        public Ficha_Atributo_Controller()
        {
            ficha_Atributo_Servico = new Ficha_Atributo_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Ficha_Atributo> Ativos() => ficha_Atributo_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Ficha_Atributo entidade)
        {
            return ficha_Atributo_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Ficha_Atributo entidade)
        {
            return ficha_Atributo_Servico.Excluir(entidade);
        }
    }
}