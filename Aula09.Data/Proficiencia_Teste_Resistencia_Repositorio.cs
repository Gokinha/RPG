using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Proficiencia_Teste_Resistencia_Repositorio : RepositorioBase<Proficiencia_Teste_Resistencia>
    {
        public IEnumerable<Proficiencia_Teste_Resistencia> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Proficiencia_Teste_Resistencia
                            .ToList();
        }
    }
}
