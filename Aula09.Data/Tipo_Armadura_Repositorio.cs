using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Tipo_Armadura_Repositorio : RepositorioBase<Tipo_Armadura>
    {
        public IEnumerable<Tipo_Armadura> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
