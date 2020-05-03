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
    public class Proficiencia_Armadura_Controller : ControllerBase
    {
        private readonly Proficiencia_Armadura_Servico proficiencia_Armadura_Servico;

        public Proficiencia_Armadura_Controller()
        {
            proficiencia_Armadura_Servico = new Proficiencia_Armadura_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Proficiencia_Armadura> Ativos() => proficiencia_Armadura_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Proficiencia_Armadura entidade)
        {
            return proficiencia_Armadura_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Proficiencia_Armadura entidade)
        {
            return proficiencia_Armadura_Servico.Excluir(entidade);
        }
    }
}