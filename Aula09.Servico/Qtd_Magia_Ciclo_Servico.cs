using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Qtd_Magia_Ciclo_Servico
    {

        private readonly Qtd_Magia_Ciclo_Repositorio _qtd_Magia_Ciclo_Repositorio;
        public Qtd_Magia_Ciclo_Servico()
        {
            _qtd_Magia_Ciclo_Repositorio = new Qtd_Magia_Ciclo_Repositorio();
        }


        public string Salvar(Qtd_Magia_Ciclo entidade)
        {
            return "Ok";
        }

        public string Excluir(Qtd_Magia_Ciclo entidade)
        {
            return "";
        }

        public IEnumerable<Qtd_Magia_Ciclo> ListarTodosComEstoqueZerado()
        {
            return _qtd_Magia_Ciclo_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
