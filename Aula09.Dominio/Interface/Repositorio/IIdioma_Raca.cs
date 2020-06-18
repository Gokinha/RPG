using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IIdioma_Raca : IRepositorioBase<Idioma_Raca>
    {
        IEnumerable<Idioma_Raca> ListarAtivos();
    }
}