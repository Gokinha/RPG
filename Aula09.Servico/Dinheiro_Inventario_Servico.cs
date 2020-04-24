using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Dinheiro_Inventario_Servico
    {

        private readonly Dinheiro_Inventario_Repositorio _dinheiro_Inventario_Repositorio;
        public Dinheiro_Inventario_Servico()
        {
            _dinheiro_Inventario_Repositorio = new Dinheiro_Inventario_Repositorio();
        }


        public string Salvar(Dinheiro_Inventario entidade)
        {
            return "Ok";
        }

        public string Excluir(Dinheiro_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Dinheiro_Inventario> ListarTodosComEstoqueZerado()
        {
            return _dinheiro_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
