﻿using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFuria : IRepositorioBase<Furia>
    {
        IEnumerable<Furia> ListarAtivos();
    }
}