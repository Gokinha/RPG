using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Monge_Repositorio : RepositorioBase<Monge>
    {
        public IEnumerable<Monge> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Monge
                            .ToList();
        }
    }
}
