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
    public class Qtd_Magias_CicloController : ControllerBase
    {
        private readonly Qtd_Magia_Ciclo_Servico qtd_Magias_Ciclo_Servico;

        public Qtd_Magias_CicloController()
        {
            qtd_Magias_Ciclo_Servico = new Qtd_Magia_Ciclo_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Qtd_Magia_Ciclo> Ativos() => qtd_Magias_Ciclo_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public NotificationResult Salvar(Qtd_Magia_Ciclo entidade)
        {
            return qtd_Magias_Ciclo_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Qtd_Magia_Ciclo entidade)
        {
            return qtd_Magias_Ciclo_Servico.Excluir(entidade);
        }
    }
}