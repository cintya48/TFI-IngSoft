﻿using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IRepoLinea
    {
        List<ModeloLinea> ListarLineas();
        void ActualizarLinea(ModeloLinea linea);
    }
}
