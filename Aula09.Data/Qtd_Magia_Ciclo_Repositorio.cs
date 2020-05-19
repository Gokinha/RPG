using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Qtd_Magia_Ciclo_Repositorio : RepositorioBase<Qtd_Magia_Ciclo>
    {
        public IEnumerable<Qtd_Magia_Ciclo> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Qtd_Magia_Ciclo
                            .ToList();
        }
    }
}
