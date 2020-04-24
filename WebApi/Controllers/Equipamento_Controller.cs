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
    public class Equipamento_Controller : ControllerBase
    {
        private readonly Equipamento_Servico equipamento_Servico;

        public Equipamento_Controller()
        {
            equipamento_Servico = new Equipamento_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Equipamento> Ativos() => equipamento_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Equipamento entidade)
        {
            return equipamento_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Equipamento entidade)
        {
            return equipamento_Servico.Excluir(entidade);
        }
    }
}