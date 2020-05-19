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
    public class Forma_DanoController : ControllerBase
    {
        private readonly Forma_Dano_Servico forma_Dano_Servico;

        public Forma_DanoController()
        {
            forma_Dano_Servico = new Forma_Dano_Servico();
        }

        [HttpGet]
        [Route("Ativos")]
        public IEnumerable<Forma_Dano> Ativos() => forma_Dano_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Forma_Dano entidade)
        {
            return forma_Dano_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Forma_Dano entidade)
        {
            return forma_Dano_Servico.Excluir(entidade);
        }
    }
}