using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class ModeloJornadaLaboral
    {

        public int ID_JL { get; set; }
        public DateTime FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public int Total_PP { get; set; }
        public int Id_Turno { get; set; }
        public int Id_Hallazgo { get; set; }
        public int id_usuario { get; set; }

        public ModeloHallazgo Hallazgo { get; set; }
        public ModeloTurno Turno { get; set; }
        public ModeloUsuario Usuario { get; set; }



    }
}
