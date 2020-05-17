using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Pericias_Repositorio : RepositorioBase<Proficiencia_Pericias>
    {
        public IEnumerable<Proficiencia_Pericias> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Proficiencia_Pericias
                            .ToList();
        }
    }
}
