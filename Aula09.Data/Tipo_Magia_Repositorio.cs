using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Tipo_Magia_Repositorio : RepositorioBase<Tipo_Magia>
    {
        public IEnumerable<Tipo_Magia> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Tipo_Magia
                            .ToList();
        }
    }
}
