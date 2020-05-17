using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Equipamento_Repositorio : RepositorioBase<Equipamento>
    {
        public IEnumerable<Equipamento> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Equipamento
                .ToList();
        }
    }
}
