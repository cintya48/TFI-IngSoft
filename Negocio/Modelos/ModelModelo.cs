using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class ModelModelo
    {
        public int SKU { get; set; }
        public string Denominacion { get; set; }
        public int LimiteSuperiorObs { get; set; }
        public int LimiteInferiorObs { get; set; }
        public int LimiteSuperiorRep { get; set; }
        public int LimiteInferiorRep { get; set; }
        public List<ModeloColor> Colores { get; set; }  



    }
}
