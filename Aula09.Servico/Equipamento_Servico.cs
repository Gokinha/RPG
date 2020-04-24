using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Equipamento_Servico
    {

        private readonly Equipamento_Repositorio _equipamento_Repositorio;
        public Equipamento_Servico()
        {
            _equipamento_Repositorio = new Equipamento_Repositorio();
        }


        public string Salvar(Equipamento entidade)
        {
            return "Ok";
        }

        public string Excluir(Equipamento entidade)
        {
            return "";
        }

        public IEnumerable<Equipamento> ListarTodosComEstoqueZerado()
        {
            return _equipamento_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
