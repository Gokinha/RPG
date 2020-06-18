using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IProficiencia_Arma_Raca : IRepositorioBase<Proficiencia_Arma_Raca>
    {
        IEnumerable<Proficiencia_Arma_Raca> ListarAtivos();
    }
}