﻿using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Arma_Repositorio : RepositorioBase<Proficiencia_Arma_Classe>
    {
        public IEnumerable<Proficiencia_Arma> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
