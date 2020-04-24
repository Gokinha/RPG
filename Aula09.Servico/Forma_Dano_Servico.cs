using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Forma_Dano_Servico
    {

        private readonly Forma_Dano_Repositorio _forma_Dano_Repositorio;
        public Forma_Dano_Servico()
        {
            _forma_Dano_Repositorio = new Forma_Dano_Repositorio();
        }


        public string Salvar(Forma_Dano entidade)
        {
            return "Ok";
        }

        public string Excluir(Forma_Dano entidade)
        {
            return "";
        }

        public IEnumerable<Forma_Dano> ListarTodosComEstoqueZerado()
        {
            return _forma_Dano_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
