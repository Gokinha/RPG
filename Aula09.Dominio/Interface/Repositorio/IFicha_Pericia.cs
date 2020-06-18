using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFicha_Pericia : IRepositorioBase<Ficha_Pericia>
    {
        IEnumerable<Ficha_Pericia> ListarAtivos();
    }
}