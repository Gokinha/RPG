using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Dado_Repositorio : RepositorioBase<Dado>
    {
        public IEnumerable<Dado> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
