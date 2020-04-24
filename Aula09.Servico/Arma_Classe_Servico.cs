using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Classe_Servico
    {

        private readonly Arma_Classe_Repositorio _arma_Classe_Repositorio;
        public Arma_Classe_Servico()
        {
            _arma_Classe_Repositorio = new Arma_Classe_Repositorio();
        }

        public string Salvar(Arma_Classe entidade)
        {
            return "Ok";
        }

        public string Excluir(Arma_Classe entidade)
        {
            return "";
        }

        public IEnumerable<Arma_Classe> ListarTodosComEstoqueZerado()
        {
            return _arma_Classe_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
