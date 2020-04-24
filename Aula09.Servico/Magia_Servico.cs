using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Magia_Servico
    {

        private readonly Magia_Repositorio _magia_Repositorio;
        public Magia_Servico()
        {
            _magia_Repositorio = new Magia_Repositorio();
        }


        public string Salvar(Magia entidade)
        {
            return "Ok";
        }

        public string Excluir(Magia entidade)
        {
            return "";
        }

        public IEnumerable<Magia> ListarTodosComEstoqueZerado()
        {
            return _magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
