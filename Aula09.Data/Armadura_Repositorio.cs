using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Armadura_Repositorio : RepositorioBase<Armadura>
    {
        public IEnumerable<Armadura> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Armadura
                .ToList();
        }
    }
}
