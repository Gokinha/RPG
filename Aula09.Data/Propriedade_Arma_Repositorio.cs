using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Propriedade_Arma_Repositorio : RepositorioBase<Propriedade_Arma>
    {
        public IEnumerable<Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
