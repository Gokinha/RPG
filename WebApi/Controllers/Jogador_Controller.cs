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
    public class Jogador_Controller : ControllerBase
    {
        private readonly Jogador_Servico jogador_Servico;

        public Jogador_Controller()
        {
            jogador_Servico = new Jogador_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Jogador> Ativos() => jogador_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Jogador entidade)
        {
            return jogador_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Jogador entidade)
        {
            return jogador_Servico.Excluir(entidade);
        }
    }
}