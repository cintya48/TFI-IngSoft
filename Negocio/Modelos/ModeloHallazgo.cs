using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class ModeloHallazgo
    {

        public int ID_Hallazgo { get; set; }
        public DateTime Fecha_Hallazgo { get; set; }
        public TimeSpan Hora_Registro { get; set; }
        public string Pie { get; set; }
        public int Defecto_id { get; set; }
       public ModeloJornadaLaboral ID_JL { get; set; }
        
    }
}
