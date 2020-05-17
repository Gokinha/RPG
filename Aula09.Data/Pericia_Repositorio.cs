using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Pericia_Repositorio : RepositorioBase<Pericia>
    {
        public IEnumerable<Pericia> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Pericia
                            .ToList();
        }
    }
}
