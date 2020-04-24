using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Nivel_Repositorio : RepositorioBase<Nivel>
    {
        public IEnumerable<Nivel> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
