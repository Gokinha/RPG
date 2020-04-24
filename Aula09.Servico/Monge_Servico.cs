using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Monge_Servico
    {

        private readonly Monge_Repositorio _monge_Repositorio;
        public Monge_Servico()
        {
            _monge_Repositorio = new Monge_Repositorio();
        }


        public string Salvar(Monge entidade)
        {
            return "Ok";
        }

        public string Excluir(Monge entidade)
        {
            return "";
        }

        public IEnumerable<Monge> ListarTodosComEstoqueZerado()
        {
            return _monge_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
