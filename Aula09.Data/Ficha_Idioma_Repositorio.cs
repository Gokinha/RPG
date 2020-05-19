using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Ficha_Idioma_Repositorio : RepositorioBase<Ficha_Idioma>
    {
        public IEnumerable<Ficha_Idioma> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Ficha_Idioma
                            .ToList();
        }
    }
}
