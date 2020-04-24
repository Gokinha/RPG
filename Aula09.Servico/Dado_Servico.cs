using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Dado_Servico
    {

        private readonly Dado_Repositorio _dado_Repositorio;
        public Dado_Servico()
        {
            _dado_Repositorio = new Dado_Repositorio();
        }


        public string Salvar(Dado entidade)
        {
            return "Ok";
        }

        public string Excluir(Dado entidade)
        {
            return "";
        }

        public IEnumerable<Dado> ListarTodosComEstoqueZerado()
        {
            return _dado_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
