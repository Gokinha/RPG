using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Arma_Classe_Repositorio : RepositorioBase<Arma_Classe>
    {
        public IEnumerable<Arma_Classe> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Arma_Classes
                .ToList();
        }
    }
}
