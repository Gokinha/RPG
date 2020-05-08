using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Arma_Propriedade_Arma_Repositorio : RepositorioBase<Arma>
    {
        public IEnumerable<Arma_Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return null;
        }

        public void Adicionar(Arma_Propriedade_Arma entidade)
        {
            throw new NotImplementedException();
        }
    }
}
