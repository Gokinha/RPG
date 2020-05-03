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
    public class Proficiencia_Teste_Resistencia_Controller : ControllerBase
    {
        private readonly Proficiencia_Teste_Resistencia_Servico proficiencia_Teste_Resistencia_Servico;

        public Proficiencia_Teste_Resistencia_Controller()
        {
            proficiencia_Teste_Resistencia_Servico = new Proficiencia_Teste_Resistencia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Proficiencia_Teste_Resistencia> Ativos() => proficiencia_Teste_Resistencia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Proficiencia_Teste_Resistencia entidade)
        {
            return proficiencia_Teste_Resistencia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Proficiencia_Teste_Resistencia entidade)
        {
            return proficiencia_Teste_Resistencia_Servico.Excluir(entidade);
        }
    }
}