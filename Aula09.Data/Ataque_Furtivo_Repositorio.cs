using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Ataque_Furtivo_Repositorio : RepositorioBase<Ataque_Furtivo>
    {
        public IEnumerable<Ataque_Furtivo> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Ataque_Furtivo
                .ToList();
        }
    }
}
