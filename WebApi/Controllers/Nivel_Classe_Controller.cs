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
    public class Nivel_Classe_Controller : ControllerBase
    {
        private readonly Nivel_Classe_Servico nivel_Classe_Servico;

        public Nivel_Classe_Controller()
        {
            nivel_Classe_Servico = new Nivel_Classe_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Nivel_Classe> Ativos() => nivel_Classe_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Nivel_Classe entidade)
        {
            return nivel_Classe_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Nivel_Classe entidade)
        {
            return nivel_Classe_Servico.Excluir(entidade);
        }
    }
}