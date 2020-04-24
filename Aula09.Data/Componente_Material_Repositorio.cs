using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Componente_Material_Repositorio : RepositorioBase<Componente_Material>
    {
        public IEnumerable<Componente_Material> ListarTodosComEstoqueZerado()
        {
            return null;
        }
    }
}
