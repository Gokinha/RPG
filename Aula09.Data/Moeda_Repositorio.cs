using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Moeda_Repositorio : RepositorioBase<Moeda>
    {
        public IEnumerable<Moeda> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Moeda
                            .ToList();
        }
    }
}
