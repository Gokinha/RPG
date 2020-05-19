using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Arma_Inventario_Repositorio : RepositorioBase<Arma_Inventario>
    {
        public IEnumerable<Arma_Inventario> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Arma_Inventario
                .ToList();
        }
    }
}
