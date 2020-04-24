using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Equipamentos_Inventario_Servico
    {

        private readonly Equipamentos_Inventario_Repositorio _equipamentos_Inventario_Repositorio;
        public Equipamentos_Inventario_Servico()
        {
            _equipamentos_Inventario_Repositorio = new Equipamentos_Inventario_Repositorio();
        }


        public string Salvar(Equipamentos_Inventario entidade)
        {
            return "Ok";
        }

        public string Excluir(Equipamentos_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Equipamentos_Inventario> ListarTodosComEstoqueZerado()
        {
            return _equipamentos_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
