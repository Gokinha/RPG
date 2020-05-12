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
    public class Ficha_PericiaController : ControllerBase
    {
        private readonly Ficha_Pericia_Servico ficha_Pericia_Servico;

        public Ficha_PericiaController()
        {
            ficha_Pericia_Servico = new Ficha_Pericia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Ficha_Pericia> Ativos() => ficha_Pericia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Ficha_Pericia entidade)
        {
            return ficha_Pericia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Ficha_Pericia entidade)
        {
            return ficha_Pericia_Servico.Excluir(entidade);
        }
    }
}