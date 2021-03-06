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
    public class Proficiencia_PericiaController : ControllerBase
    {
        private readonly Proficiencia_Pericia_Servico proficiencia_Pericia_Servico;

        public Proficiencia_PericiaController()
        {
            proficiencia_Pericia_Servico = new Proficiencia_Pericia_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Proficiencia_Pericias> Ativos() => proficiencia_Pericia_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Proficiencia_Pericias entidade)
        {
            return proficiencia_Pericia_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Proficiencia_Pericias entidade)
        {
            return proficiencia_Pericia_Servico.Excluir(entidade);
        }
    }
}