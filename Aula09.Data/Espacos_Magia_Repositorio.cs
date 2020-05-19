using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Espacos_Magia_Repositorio : RepositorioBase<Espacos_Magia>
    {
        public IEnumerable<Espacos_Magia> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Espaco_Magia
                            .ToList();
        }
    }
}
