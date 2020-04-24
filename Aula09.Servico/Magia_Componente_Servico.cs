using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Magia_Componente_Servico
    {

        private readonly Magia_Componente_Repositorio _magia_Componente_Repositorio;
        public Magia_Componente_Servico()
        {
            _magia_Componente_Repositorio = new Magia_Componente_Repositorio();
        }


        public string Salvar(Magia_Componente entidade)
        {
            return "Ok";
        }

        public string Excluir(Magia_Componente entidade)
        {
            return "";
        }

        public IEnumerable<Magia_Componente> ListarTodosComEstoqueZerado()
        {
            return _magia_Componente_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
