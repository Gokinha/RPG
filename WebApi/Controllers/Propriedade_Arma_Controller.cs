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
    public class Propriedade_Arma_Controller : ControllerBase
    {
        private readonly Propriedade_Arma_Servico propriedade_Arma_Servico;

        public Propriedade_Arma_Controller()
        {
            propriedade_Arma_Servico = new Propriedade_Arma_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Propriedade_Arma> Ativos() => raca_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Propriedade_Arma entidade)
        {
            return propriedade_Arma_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Propriedade_Arma entidade)
        {
            return propriedade_Arma_Servico.Excluir(entidade);
        }
    }
}