using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Idioma_Raca_Repositorio : RepositorioBase<Idioma_Raca>
    {
        public IEnumerable<Idioma_Raca> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Idioma_Raca
                            .ToList();
        }
    }
}
