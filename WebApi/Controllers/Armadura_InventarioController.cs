using System.Collections.Generic;
using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using Aula09.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Armadura_InventarioController : ControllerBase
    {
        private readonly Armadura_Inventario_Servico armadura_Inventario_Servico;

        public Armadura_InventarioController()
        {
            armadura_Inventario_Servico = new Armadura_Inventario_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Armadura_Inventario> ListarTodosComEstoqueZerado()
        {
            return armadura_Inventario_Servico.ListarTodosComEstoqueZerado();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Armadura_Inventario entidade)
        {
            return armadura_Inventario_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Armadura_Inventario entidade)
        {
            return armadura_Inventario_Servico.Excluir(entidade);
        }
    }
}