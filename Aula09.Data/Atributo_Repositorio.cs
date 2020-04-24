using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Atributo_Repositorio : RepositorioBase<Atributo>
    {
        public IEnumerable<Atributo> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
