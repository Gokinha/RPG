using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Magia_Componente_Repositorio : RepositorioBase<Magia_Componente>
    {
        public IEnumerable<Magia_Componente> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Magia_Componente
                            .ToList();
        }
    }
}
