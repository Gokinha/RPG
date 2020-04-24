using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Furia_Servico
    {

        private readonly Furia_Repositorio _furia_Repositorio;
        public Furia_Servico()
        {
            _furia_Repositorio = new Furia_Repositorio();
        }


        public string Salvar(Furia entidade)
        {
            return "Ok";
        }

        public string Excluir(Furia entidade)
        {
            return "";
        }

        public IEnumerable<Furia> ListarTodosComEstoqueZerado()
        {
            return _furia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
