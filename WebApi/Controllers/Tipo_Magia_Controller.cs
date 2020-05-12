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
    public class Tipo_Magia_Controller : ControllerBase
    {
        private readonly Tipo_Magia_Servico tipo_Magia_Servico;

        public Tipo_Magia_Controller()
        {
            tipo_Magia_Servico = new Tipo_Magia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Tipo_Magia> Ativos() => tipo_Magia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Tipo_Magia entidade)
        {
            return tipo_Magia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Tipo_Magia entidade)
        {
            return tipo_Magia_Servico.Excluir(entidade);
        }
    }
}