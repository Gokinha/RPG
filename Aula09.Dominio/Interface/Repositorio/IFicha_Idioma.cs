using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFicha_Idioma : IRepositorioBase<Ficha_Idioma>
    {
        IEnumerable<Ficha_Idioma> ListarAtivos();
    }
}