using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IProficiencia_Pericias : IRepositorioBase<Proficiencia_Pericias>
    {
        IEnumerable<Proficiencia_Pericias> ListarAtivos();
    }
}