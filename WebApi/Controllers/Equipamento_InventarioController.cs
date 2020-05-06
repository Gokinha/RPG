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
    public class Equipamento_InventarioController : ControllerBase
    {
        private readonly Equipamentos_Inventario_Servico equipamento_Inventario_Servico;

        public Equipamento_InventarioController()
        {
            equipamento_Inventario_Servico = new Equipamentos_Inventario_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Equipamentos_Inventario> Ativos() => equipamento_Inventario_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Equipamentos_Inventario entidade)
        {
            return equipamento_Inventario_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Equipamentos_Inventario entidade)
        {
            return equipamento_Inventario_Servico.Excluir(entidade);
        }
    }
}