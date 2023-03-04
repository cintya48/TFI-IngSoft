using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class ModeloOP
    {
        public int Numero_OP { get; set; }
        public DateTime Fecha_I { get; set; }
        public Nullable<System.DateTime> Fecha_F { get; set; }
        public int num_linea { get; set; }
        public string Estado { get; set; }
        public int codigo_color { get; set; }
        public int sku_modelo { get; set; }
        public int id_usuario { get; set; }
        public Nullable<int> id_jornada { get; set; }

        public ModeloColor Color { get; set; }
        public ModeloJornadaLaboral JornadaLaboral { get; set; }
        public ModeloLinea Linea { get; set; }
        public  ModelModelo Modelo { get; set; }
        public ModeloUsuario Usuario { get; set; }



    }
}
