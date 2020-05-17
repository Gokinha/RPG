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
    public class Dinheiro_InventarioController : ControllerBase
    {
        private readonly Dinheiro_Inventario_Servico dinheiro_Inventario_Servico;

        public Dinheiro_InventarioController()
        {
            dinheiro_Inventario_Servico = new Dinheiro_Inventario_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Dinheiro_Inventario> Ativos() => dinheiro_Inventario_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Dinheiro_Inventario entidade)
        {
            return dinheiro_Inventario_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Dinheiro_Inventario entidade)
        {
            return dinheiro_Inventario_Servico.Excluir(entidade);
        }
    }
}