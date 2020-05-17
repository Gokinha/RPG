using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Inventario_Repositorio : RepositorioBase<Inventario>
    {
        public IEnumerable<Inventario> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Inventario
                            .ToList();
        }
    }
}
