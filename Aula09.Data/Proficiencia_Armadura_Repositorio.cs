using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Armadura_Repositorio : RepositorioBase<Proficiencia_Armadura>
    {
        public IEnumerable<Proficiencia_Armadura> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Proficiencia_Armadura
                            .ToList();
        }
    }
}
