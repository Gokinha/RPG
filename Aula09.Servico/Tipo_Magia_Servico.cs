using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Tipo_Magia_Servico
    {

        private readonly Tipo_Magia_Repositorio _tipo_Magia_Repositorio;
        public Tipo_Magia_Servico()
        {
            _tipo_Magia_Repositorio = new Tipo_Magia_Repositorio();
        }


        public string Salvar(Tipo_Magia entidade)
        {
            return "Ok";
        }

        public string Excluir(Tipo_Magia entidade)
        {
            return "";
        }

        public IEnumerable<Tipo_Magia> ListarTodosComEstoqueZerado()
        {
            return _tipo_Magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
