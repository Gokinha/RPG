using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Atributo_Servico
    {

        private readonly Ficha_Atributo_Repositorio _ficha_Atributo_Repositorio;
        public Ficha_Atributo_Servico()
        {
            _ficha_Atributo_Repositorio = new Ficha_Atributo_Repositorio();
        }


        public string Salvar(Ficha_Atributo entidade)
        {
            return "Ok";
        }

        public string Excluir(Ficha_Atributo entidade)
        {
            return "";
        }

        public IEnumerable<Ficha_Atributo> ListarTodosComEstoqueZerado()
        {
            return _ficha_Atributo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
