using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Furia_Repositorio : RepositorioBase<Furia>
    {
        public IEnumerable<Furia> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Furia
                            .ToList();
        }
    }
}
