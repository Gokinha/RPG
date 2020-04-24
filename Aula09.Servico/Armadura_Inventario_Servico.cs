using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Armadura_Inventario_Servico
    {

        private readonly Armadura_Inventario_Repositorio _armadura_Inventario_Repositorio;
        public Armadura_Inventario_Servico()
        {
            _armadura_Inventario_Repositorio = new Armadura_Inventario_Repositorio();
        }


        public string Salvar(Armadura_Inventario entidade)
        {
            return "Ok";
        }

        public string Excluir(Armadura_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Armadura_Inventario> ListarTodosComEstoqueZerado()
        {
            return _armadura_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
