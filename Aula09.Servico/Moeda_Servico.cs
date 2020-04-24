using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Moeda_Servico
    {

        private readonly Moeda_Repositorio _moeda_Repositorio;
        public Moeda_Servico()
        {
            _moeda_Repositorio = new Moeda_Repositorio();
        }


        public string Salvar(Moeda entidade)
        {
            return "Ok";
        }

        public string Excluir(Moeda entidade)
        {
            return "";
        }

        public IEnumerable<Moeda> ListarTodosComEstoqueZerado()
        {
            return _moeda_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
