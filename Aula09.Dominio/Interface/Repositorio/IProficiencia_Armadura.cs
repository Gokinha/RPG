using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IProficiencia_Armadura : IRepositorioBase<Proficiencia_Armadura>
    {
        IEnumerable<Proficiencia_Armadura> ListarAtivos();
    }
}