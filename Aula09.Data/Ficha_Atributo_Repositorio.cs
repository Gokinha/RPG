using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Ficha_Atributo_Repositorio : RepositorioBase<Ficha_Atributo>
    {
        public IEnumerable<Ficha_Atributo> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Ficha_Atributo
                            .ToList();
        }
    }
}
