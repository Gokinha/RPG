using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Propriedade_Arma_Servico
    {

        private readonly Arma_Propriedade_Arma_Repositorio _arma_Propriedade_Arma_Repositorio;
        public Arma_Propriedade_Arma_Servico()
        {
            _arma_Propriedade_Arma_Repositorio = new Arma_Propriedade_Arma_Repositorio();
        }


        public string Salvar(Arma_Propriedade_Arma entidade)
        {
            return "Ok";
        }

        public string Excluir(Arma_Propriedade_Arma entidade)
        {
            return "";
        }

        public IEnumerable<Arma_Propriedade_Arma> ListarTodosComEstoqueZerado()
        {
            return _arma_Propriedade_Arma_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
