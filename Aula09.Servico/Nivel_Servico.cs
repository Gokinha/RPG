using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Nivel_Servico
    {

        private readonly Nivel_Repositorio _nivel_Repositorio;
        public Nivel_Servico()
        {
            _nivel_Repositorio = new Nivel_Repositorio();
        }


        public string Salvar(Nivel entidade)
        {
            return "Ok";
        }

        public string Excluir(Nivel entidade)
        {
            return "";
        }

        public IEnumerable<Nivel> ListarTodosComEstoqueZerado()
        {
            return _nivel_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
