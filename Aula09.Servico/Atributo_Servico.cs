using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Atributo_Servico
    {

        private readonly Atributo_Repositorio _atributo_Repositorio;
        public Atributo_Servico()
        {
            _atributo_Repositorio = new Atributo_Repositorio();
        }


        public string Salvar(Atributo entidade)
        {
            return "Ok";
        }

        public string Excluir(Atributo entidade)
        {
            return "";
        }

        public IEnumerable<Atributo> ListarTodosComEstoqueZerado()
        {
            return _atributo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
