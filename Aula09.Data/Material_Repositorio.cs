using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Material_Repositorio : RepositorioBase<Material>
    {
        public IEnumerable<Material> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
