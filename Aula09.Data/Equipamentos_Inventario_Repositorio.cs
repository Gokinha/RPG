using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Equipamentos_Inventario_Repositorio : RepositorioBase<Equipamentos_Inventario>
    {
        public IEnumerable<Equipamentos_Inventario> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
