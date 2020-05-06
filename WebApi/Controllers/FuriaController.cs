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
    public class FuriaController : ControllerBase
    {
        private readonly Furia_Servico furia_Servico;

        public FuriaController()
        {
            furia_Servico = new Furia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Furia> Ativos() => furia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Furia entidade)
        {
            return furia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Furia entidade)
        {
            return furia_Servico.Excluir(entidade);
        }
    }
}