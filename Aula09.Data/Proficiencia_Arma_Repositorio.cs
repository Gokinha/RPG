using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Arma_Repositorio : RepositorioBase<Proficiencia_Arma>
    {
        public IEnumerable<Proficiencia_Arma> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Proficiencia_Arma
                            .ToList();
        }
    }
}
