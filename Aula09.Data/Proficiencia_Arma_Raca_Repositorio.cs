using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Arma_Raca_Repositorio : RepositorioBase<Proficiencia_Arma_Raca>
    {
        public IEnumerable<Proficiencia_Arma_Raca> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Proficiencia_Arma_Raca
                            .ToList();
        }
    }
}
