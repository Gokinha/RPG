using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Arma_Repositorio : RepositorioBase<Arma>
    {
        public IEnumerable<Arma> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
