﻿using System;
using System.Collections.Generic;
using Aula09.Dominio;
using Microsoft.AspNetCore.Mvc;
using Aula09.Comum.NotificationPattern;
using Aula09.Servico;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Monge_Controller : ControllerBase
    {
        private readonly Monge_Servico monge_Servico;

        public Monge_Controller()
        {
            monge_Servico = new Monge_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Monge> Ativos() => monge_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Monge entidade)
        {
            return monge_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Monge entidade)
        {
            return monge_Servico.Excluir(entidade);
        }
    }
}