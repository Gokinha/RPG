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
    public class Magia_ComponenteController : ControllerBase
    {
        private readonly Magia_Componente_Servico magia_Componente_Servico;

        public Magia_ComponenteController()
        {
            magia_Componente_Servico = new Magia_Componente_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Magia_Componente> Ativos() => magia_Componente_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Magia_Componente entidade)
        {
            return magia_Componente_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Magia_Componente entidade)
        {
            return magia_Componente_Servico.Excluir(entidade);
        }
    }
}