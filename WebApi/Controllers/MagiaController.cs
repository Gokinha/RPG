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
    public class MagiaController : ControllerBase
    {
        private readonly Magia_Servico magia_Servico;

        public MagiaController()
        {
            magia_Servico = new Magia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Magia> Ativos() => magia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Magia entidade)
        {
            return magia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Magia entidade)
        {
            return magia_Servico.Excluir(entidade);
        }
    }
}