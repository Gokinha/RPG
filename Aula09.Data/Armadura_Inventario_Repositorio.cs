using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Armadura_Inventario_Repositorio : RepositorioBase<Armadura_Inventario>
    {
        public IEnumerable<Armadura_Inventario> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
