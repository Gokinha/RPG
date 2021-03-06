﻿using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Raca_Repositorio : RepositorioBase<Raca>
    {
        public IEnumerable<Raca> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Raca
                            .ToList();
        }
    }
}
