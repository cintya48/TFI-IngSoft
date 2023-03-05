using Datos;
using Negocio.Interfaces;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorio
{
    public class RepoLinea :IRepoLinea
    {
        public void ActualizarLinea(ModeloLinea linea)
        {
            using (var db = new TFI_ControlCalidadEntities())
            {
                var actualizar_linea = db.Linea.Find(linea.Numero_Linea);
                actualizar_linea.Estado = linea.Estado;


            }
        }

        public List<ModeloLinea> ListarLineas()
        {
            using (var db = new TFI_ControlCalidadEntities())
            {

                return db.Linea.Select(MapearDB).ToList();

            }
        }

        private ModeloLinea MapearDB(Linea tabla)
        {
            return new ModeloLinea()
            {
               Numero_Linea = tabla.Numero_Linea,
               Estado = tabla.Estado,
            };
        }

    }
}
