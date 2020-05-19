using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Caracteristicas_Repositorio : RepositorioBase<Caracteristicas>
    {
        public IEnumerable<Caracteristicas> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Caracteristicas
                .ToList();
        }
    }
}
