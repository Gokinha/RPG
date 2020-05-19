using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Ciclo_Magia_Repositorio : RepositorioBase<Ciclo_Magia>
    {
        public IEnumerable<Ciclo_Magia> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Ciclo_Magia
                .ToList();
        }
    }
}
