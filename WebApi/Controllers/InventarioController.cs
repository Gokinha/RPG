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
    public class InventarioController : ControllerBase
    {
        private readonly Inventario_Servico inventario_Servico;

        public InventarioController()
        {
            inventario_Servico = new Inventario_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Inventario> Ativos() => inventario_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Inventario entidade)
        {
            return inventario_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Inventario entidade)
        {
            return inventario_Servico.Excluir(entidade);
        }
    }
}