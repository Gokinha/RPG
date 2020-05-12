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
    public class MaterialController : ControllerBase
    {
        private readonly Material_Servico material_Servico;

        public MaterialController()
        {
            material_Servico = new Material_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Material> Ativos() => material_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Material entidade)
        {
            return material_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Material entidade)
        {
            return material_Servico.Excluir(entidade);
        }
    }
}