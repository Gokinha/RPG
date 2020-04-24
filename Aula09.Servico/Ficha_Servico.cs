using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Servico
    {

        private readonly Ficha_Repositorio _ficha_Repositorio;
        public Ficha_Servico()
        {
            _ficha_Repositorio = new Ficha_Repositorio();
        }


        public string Salvar(Ficha entidade)
        {
            return "Ok";
        }

        public string Excluir(Ficha entidade)
        {
            return "";
        }

        public IEnumerable<Ficha> ListarTodosComEstoqueZerado()
        {
            return _ficha_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
