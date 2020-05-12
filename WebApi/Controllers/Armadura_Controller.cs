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
    public class Armadura_Controller : ControllerBase
    {
        private readonly Armadura_Servico armadura_Servico;

        public Armadura_Controller()
        {
            armadura_Servico = new Armadura_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Armadura> Ativos() => armadura_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Armadura entidade)
        {
            return armadura_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Armadura entidade)
        {
            return armadura_Servico.Excluir(entidade);
        }
    }
}