using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Inventario_Servico
    {

        private readonly Inventario_Repositorio _inventario_Repositorio;
        public Inventario_Servico()
        {
            _inventario_Repositorio = new Inventario_Repositorio();
        }


        public string Salvar(Inventario entidade)
        {
            return "Ok";
        }

        public string Excluir(Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Inventario> ListarTodosComEstoqueZerado()
        {
            return _inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
