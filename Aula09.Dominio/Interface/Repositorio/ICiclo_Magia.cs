using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface ICiclo_Magia : IRepositorioBase<Ciclo_Magia>
    {
        IEnumerable<Ciclo_Magia> ListarAtivos();
    }
}