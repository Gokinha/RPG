using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Componente_Repositorio : RepositorioBase<Componente>
    {
        public IEnumerable<Componente> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
