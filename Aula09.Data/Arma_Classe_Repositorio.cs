using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Arma_Classe_Repositorio : RepositorioBase<Arma_Classe>
    {
        public IEnumerable<Arma_Classe> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
