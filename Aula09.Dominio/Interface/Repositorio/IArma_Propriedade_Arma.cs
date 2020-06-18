using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IArma_Propriedade_Arma : IRepositorioBase<Arma_Propriedade_Arma>
    {
        IEnumerable<Arma_Propriedade_Arma> ListarAtivos();
    }
}