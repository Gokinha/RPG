using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Magia_Repositorio : RepositorioBase<Magia>
    {
        public IEnumerable<Magia> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
