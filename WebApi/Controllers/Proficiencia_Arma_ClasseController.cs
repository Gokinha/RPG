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
    public class Proficiencia_Arma_ClasseController : ControllerBase
    {
        private readonly Proficiencia_Arma_Classe_Servico proficiencia_Arma_Classe_Servico;

        public Proficiencia_Arma_ClasseController()
        {
            proficiencia_Arma_Classe_Servico = new Proficiencia_Arma_Classe_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Proficiencia_Arma_Classe> Ativos() => proficiencia_Arma_Classe_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Proficiencia_Arma_Classe entidade)
        {
            return proficiencia_Arma_Classe_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Proficiencia_Arma_Classe entidade)
        {
            return proficiencia_Arma_Classe_Servico.Excluir(entidade);
        }
    }
}