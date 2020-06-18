using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IDinheiro_Inventario : IRepositorioBase<Dinheiro_Inventario>
    {
        IEnumerable<Dinheiro_Inventario> ListarAtivos();
    }
}