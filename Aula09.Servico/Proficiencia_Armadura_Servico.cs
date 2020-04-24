using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Armadura_Servico
    {

        private readonly Proficiencia_Armadura_Repositorio _proficiencia_Armadura_Repositorio;
        public Proficiencia_Armadura_Servico()
        {
            _proficiencia_Armadura_Repositorio = new Proficiencia_Armadura_Repositorio();
        }


        public string Salvar(Proficiencia_Armadura entidade)
        {
            return "Ok";
        }

        public string Excluir(Proficiencia_Armadura entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Armadura> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Armadura_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
