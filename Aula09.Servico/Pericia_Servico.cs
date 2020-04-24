using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Pericia_Servico
    {

        private readonly Pericia_Repositorio _pericia_Repositorio;
        public Pericia_Servico()
        {
            _pericia_Repositorio = new Pericia_Repositorio();
        }


        public string Salvar(Pericia entidade)
        {
            return "Ok";
        }

        public string Excluir(Pericia entidade)
        {
            return "";
        }

        public IEnumerable<Pericia> ListarTodosComEstoqueZerado()
        {
            return _pericia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
