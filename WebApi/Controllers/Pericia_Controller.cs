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
    public class Pericia_Controller : ControllerBase
    {
        private readonly Pericia_Servico pericia_Servico;

        public Pericia_Controller()
        {
            pericia_Servico = new Pericia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Pericia> Ativos() => pericia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Pericia entidade)
        {
            return pericia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Pericia entidade)
        {
            return pericia_Servico.Excluir(entidade);
        }
    }
}