using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Jogador_Servico
    {

        private readonly Jogador_Repositorio _jogador_Repositorio;
        public Jogador_Servico()
        {
            _jogador_Repositorio = new Jogador_Repositorio();
        }


        public string Salvar(Jogador entidade)
        {
            return "Ok";
        }

        public string Excluir(Jogador entidade)
        {
            return "";
        }

        public IEnumerable<Jogador> ListarTodosComEstoqueZerado()
        {
            return _jogador_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
