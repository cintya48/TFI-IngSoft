using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IRepoOrdenProduccion
    {
        void IniciarOP(ModeloOP op);
        List<ModeloOP> ListarOP();

    }
}
