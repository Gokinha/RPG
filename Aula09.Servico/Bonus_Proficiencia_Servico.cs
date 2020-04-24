using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Bonus_Proficiencia_Servico
    {

        private readonly Bonus_Proficiencia_Repositorio _bonus_Proficiencia_Repositorio;
        public Bonus_Proficiencia_Servico()
        {
            _bonus_Proficiencia_Repositorio = new Bonus_Proficiencia_Repositorio();
        }


        public string Salvar(Bonus_Proficiencia entidade)
        {
            return "Ok";
        }

        public string Excluir(Bonus_Proficiencia entidade)
        {
            return "";
        }

        public IEnumerable<Bonus_Proficiencia> ListarTodosComEstoqueZerado()
        {
            return _bonus_Proficiencia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
