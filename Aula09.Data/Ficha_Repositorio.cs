using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Ficha_Repositorio : RepositorioBase<Ficha>
    {
        public IEnumerable<Ficha> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Ficha
                            .ToList();
        }
    }
}
