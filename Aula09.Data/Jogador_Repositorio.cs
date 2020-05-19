using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Jogador_Repositorio : RepositorioBase<Jogador>
    {
        public IEnumerable<Jogador> ListarTodosComEstoqueZerado()
        {
            return Contexto
                            .Jogador
                            .ToList();
        }
    }
}
