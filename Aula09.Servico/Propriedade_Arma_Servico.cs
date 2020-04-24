using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Propriedade_Arma_Servico
    {

        private readonly Propriedade_Arma_Repositorio _propriedade_Arma_Repositorio;
        public Propriedade_Arma_Servico()
        {
            _propriedade_Arma_Repositorio = new Propriedade_Arma_Repositorio();
        }


        public string Salvar(Propriedade_Arma entidade)
        {
            return "Ok";
        }

        public string Excluir(Propriedade_Arma entidade)
        {
            return "";
        }

        public IEnumerable<Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return _propriedade_Arma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
