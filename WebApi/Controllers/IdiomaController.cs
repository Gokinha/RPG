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
    public class IdiomaController : ControllerBase
    {
        private readonly Idioma_Servico idioma_Servico;

        public IdiomaController()
        {
            idioma_Servico = new Idioma_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Idioma> Ativos() => idioma_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Idioma entidade)
        {
            return idioma_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Idioma entidade)
        {
            return idioma_Servico.Excluir(entidade);
        }
    }
}