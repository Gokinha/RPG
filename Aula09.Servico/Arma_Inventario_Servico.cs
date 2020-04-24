using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Arma_Inventario_Servico
    {

        private readonly Arma_Inventario_Repositorio _arma_Inventario_Repositorio;
        public Arma_Inventario_Servico()
        {
            _arma_Inventario_Repositorio = new Arma_Inventario_Repositorio();
        }


        public string Salvar(Arma_Inventario entidade)
        {
            return "Ok";
        }

        public string Excluir(Arma_Inventario entidade)
        {
            return "";
        }

        public IEnumerable<Arma_Inventario> ListarTodosComEstoqueZerado()
        {
            return _arma_Inventario_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
