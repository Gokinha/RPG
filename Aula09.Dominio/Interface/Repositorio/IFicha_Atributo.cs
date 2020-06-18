using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFicha_Atributo : IRepositorioBase<Ficha_Atributo>
    {
        IEnumerable<Ficha_Atributo> ListarAtivos();
    }
}