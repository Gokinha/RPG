using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Forma_Dano_Repositorio : RepositorioBase<Forma_Dano>
    {
        public IEnumerable<Forma_Dano> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Forma_Dano;
                //.CodFormaDano(f => f.Marca)
                //.ToList();
        }
    }
}
