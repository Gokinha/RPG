﻿using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Classe_Repositorio : RepositorioBase<Classe>
    {
        public IEnumerable<Classe> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Classe
                .ToList();
        }
    }
}
