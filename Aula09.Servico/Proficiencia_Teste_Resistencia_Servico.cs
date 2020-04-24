using System;
using System.Collections.Generic;
using Aula09.Dados;
using Aula09.Dominio;

namespace Aula09.Servico
{
    public class Proficiencia_Teste_Resistencia_Servico
    {

        private readonly Proficiencia_Teste_Resistencia_Repositorio _proficiencia_Teste_Resistencia_Repositorio;
        public Proficiencia_Teste_Resistencia_Servico()
        {
            _proficiencia_Teste_Resistencia_Repositorio = new Proficiencia_Teste_Resistencia_Repositorio();
        }


        public string Salvar(Proficiencia_Teste_Resistencia entidade)
        {
            return "Ok";
        }

        public string Excluir(Proficiencia_Teste_Resistencia entidade)
        {
            return "";
        }

        public IEnumerable<Proficiencia_Teste_Resistencia> ListarTodosComEstoqueZerado()
        {
            return _proficiencia_Teste_Resistencia_Repositorio.ListarTodosComEstoqueZerado();
        }
    }
}
