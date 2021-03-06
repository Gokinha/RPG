﻿using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Idioma_Repositorio : RepositorioBase<Idioma>
    {
        public IEnumerable<Idioma> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Idioma
                            .ToList();
        }
    }
}
