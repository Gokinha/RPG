using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IArmadura_Inventario : IRepositorioBase<Armadura_Inventario>
    {
        IEnumerable<Armadura_Inventario> ListarAtivos();
    }
}