using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Habilidade_Repositorio : RepositorioBase<Habilidade>
    {
        public IEnumerable<Habilidade> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Habilidade
                            .ToList();
        }
    }
}
