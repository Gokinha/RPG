using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ficha_Pericia_Servico
    {

        private readonly Ficha_Pericia_Repositorio _ficha_Pericia_Repositorio;
        public Ficha_Pericia_Servico()
        {
            _ficha_Pericia_Repositorio = new Ficha_Pericia_Repositorio();
        }


        public string Salvar(Ficha_Pericia entidade)
        {
            return "Ok";
        }

        public string Excluir(Ficha_Pericia entidade)
        {
            return "";
        }

        public IEnumerable<Ficha_Pericia> ListarTodosComEstoqueZerado()
        {
            return _ficha_Pericia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
