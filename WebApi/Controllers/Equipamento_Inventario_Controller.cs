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
    public class Equipamento_Inventario_Controller : ControllerBase
    {
        private readonly Equipamento_Inventario_Servico equipamento_Inventario_Servico;

        public Equipamento_Inventario_Controller()
        {
            equipamento_Inventario_Servico = new Equipamento_Inventario_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Equipamento_Inventario> Ativos() => equipamento_Inventario_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Equipamento_Inventario entidade)
        {
            return equipamento_Inventario_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Equipamento_Inventario entidade)
        {
            return equipamento_Inventario_Servico.Excluir(entidade);
        }
    }
}