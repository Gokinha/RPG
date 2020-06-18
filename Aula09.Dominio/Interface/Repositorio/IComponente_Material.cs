using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IComponente_Material : IRepositorioBase<Componente_Material>
    {
        IEnumerable<Componente_Material> ListarAtivos();
    }
}