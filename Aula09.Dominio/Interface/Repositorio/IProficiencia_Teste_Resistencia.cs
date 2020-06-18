using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IProficiencia_Teste_Resistencia : IRepositorioBase<Proficiencia_Teste_Resistencia>
    {
        IEnumerable<Proficiencia_Teste_Resistencia> ListarAtivos();
    }
}