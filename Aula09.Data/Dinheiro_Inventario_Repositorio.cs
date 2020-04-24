using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Dinheiro_Inventario_Repositorio : RepositorioBase<Dinheiro_Inventario>
    {
        public IEnumerable<Dinheiro_Inventario> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
