using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Arma_Classe_Repositorio : RepositorioBase<Proficiencia_Arma_Classe>
    {
        public IEnumerable<Proficiencia_Arma_Classe> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Proficiencia_Arma_Classe
                            .ToList();
        }
    }
}
