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
    public class Componente_Material_Controller : ControllerBase
    {
        private readonly Componente_Material_Servico componente_Material_Servico;

        public Componente_Material_Controller()
        {
            componente_Material_Servico = new Componente_Material_Servico();
        }

        [HttpGet("Ativos")]
        public IEnumerable<Componente_Material> Ativos() => componente_Material_Servico.ListarTodosComEstoqueZerado();


        [HttpPost("Salvar")]
        public string Salvar(Componente_Material entidade)
        {
            return componente_Material_Servico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Componente_Material entidade)
        {
            return componente_Material_Servico.Excluir(entidade);
        }
    }
}