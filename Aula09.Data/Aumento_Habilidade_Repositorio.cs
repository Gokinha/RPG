using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Aumento_Habilidade_Repositorio : RepositorioBase<Aumento_Habilidade>
    {
        public IEnumerable<Aumento_Habilidade> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Aumento_Habilidade
                .ToList();
        }
    }
}
