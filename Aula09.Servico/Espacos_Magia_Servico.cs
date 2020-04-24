using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Espacos_Magia_Servico
    {

        private readonly Espacos_Magia_Repositorio _espacos_Magia_Repositorio;
        public Espacos_Magia_Servico()
        {
            _espacos_Magia_Repositorio = new Espacos_Magia_Repositorio();
        }


        public string Salvar(Espacos_Magia entidade)
        {
            return "Ok";
        }

        public string Excluir(Espacos_Magia entidade)
        {
            return "";
        }

        public IEnumerable<Espacos_Magia> ListarTodosComEstoqueZerado()
        {
            return _espacos_Magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
