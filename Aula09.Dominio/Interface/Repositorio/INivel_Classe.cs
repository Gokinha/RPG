using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface INivel_Classe : IRepositorioBase<Nivel_Classe>
    {
        IEnumerable<Nivel_Classe> ListarAtivos();
    }
}