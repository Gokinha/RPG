using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Ciclo_Magia_Servico
    {

        private readonly Ciclo_Magia_Repositorio _ciclo_Magia_Repositorio;
        public Ciclo_Magia_Servico()
        {
            _ciclo_Magia_Repositorio = new Ciclo_Magia_Repositorio();
        }


        public string Salvar(Ciclo_Magia entidade)
        {
            return "Ok";
        }

        public string Excluir(Ciclo_Magia entidade)
        {
            return "";
        }

        public IEnumerable<Ciclo_Magia> ListarTodosComEstoqueZerado()
        {
            return _ciclo_Magia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
