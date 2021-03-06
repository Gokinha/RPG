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
    public class Tipo_ArmaduraController : ControllerBase
    {
        private readonly Tipo_Armadura_Servico tipo_Armadura_Servico;

        public Tipo_ArmaduraController()
        {
            tipo_Armadura_Servico = new Tipo_Armadura_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Tipo_Armadura> Ativos() => tipo_Armadura_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Tipo_Armadura entidade)
        {
            return tipo_Armadura_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Tipo_Armadura entidade)
        {
            return tipo_Armadura_Servico.Excluir(entidade);
        }
    }
}