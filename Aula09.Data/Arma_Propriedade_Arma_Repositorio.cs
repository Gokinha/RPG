using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula09.Dados
{
    public class Arma_Propriedade_Arma_Repositorio : RepositorioBase<Arma>
    {
        public IEnumerable<Arma_Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Arma_Propriedade_Arma
                .ToList();
        }

        public void Adicionar(Arma_Propriedade_Arma entidade)
        {
            throw new NotImplementedException();
        }
    }
}
