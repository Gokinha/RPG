using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Raca_Servico
    {

        private readonly Raca_Repositorio _raca_Repositorio;
        public Raca_Servico()
        {
            _raca_Repositorio = new Raca_Repositorio();
        }


        public string Salvar(Raca entidade)
        {
            return "Ok";
        }

        public string Excluir(Raca entidade)
        {
            return "";
        }

        public IEnumerable<Raca> ListarTodosComEstoqueZerado()
        {
            return _raca_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
