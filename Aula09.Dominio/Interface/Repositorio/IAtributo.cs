using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IAtributo : IRepositorioBase<Atributo>
    {
        IEnumerable<Atributo> ListarAtivos();
    }
}