using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IBonus_Proficiencia : IRepositorioBase<Bonus_Proficiencia>
    {
        IEnumerable<Bonus_Proficiencia> ListarAtivos();
    }
}