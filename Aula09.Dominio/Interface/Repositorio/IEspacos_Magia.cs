using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IEspacos_Magia : IRepositorioBase<Espacos_Magia>
    {
        IEnumerable<Espacos_Magia> ListarAtivos();
    }
}