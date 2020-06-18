using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface ICaracteristica_Raca : IRepositorioBase<Caracteristica_Raca>
    {
        IEnumerable<Caracteristica_Raca> ListarAtivos();
    }
}