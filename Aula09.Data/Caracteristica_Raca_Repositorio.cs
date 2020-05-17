using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Caracteristica_Raca_Repositorio : RepositorioBase<Caracteristica_Raca>
    {
        public IEnumerable<Caracteristica_Raca> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Caracteristica_Raca
                .ToList();
        }
    }
}
