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
    public class Bonus_Proficiencia_Controller : ControllerBase
    {
        private readonly Bonus_Proficiencia_Servico bonus_Proficiencia_Servico;

        public Bonus_Proficiencia_Controller()
        {
            bonus_Proficiencia_Servico = new Bonus_Proficiencia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Bonus_Proficiencia> Ativos() => bonus_Proficiencia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Bonus_Proficiencia entidade)
        {
            return bonus_Proficiencia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Bonus_Proficiencia entidade)
        {
            return bonus_Proficiencia_Servico.Excluir(entidade);
        }
    }
}