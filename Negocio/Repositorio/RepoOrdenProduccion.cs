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
    public class RepoOrdenProduccion : IRepoOrdenProduccion
    {
       

        public void IniciarOP(ModeloOP op)
        {

            using (var db = new TFI_ControlCalidadEntities())
            {
                db.Orden_Produccion.Add(EnviarDB(op));
                db.SaveChanges();

            }
        }

        public List<ModeloOP> ListarOP()
        {
            using (var db = new TFI_ControlCalidadEntities())
            {
                return db.Orden_Produccion.Select(MapearDB).ToList();
            }
                
        }

        public void ActualizarOP(ModeloOP op)
        {
            using (var db = new TFI_ControlCalidadEntities())
            {
                var op_actualizada = db.Orden_Produccion.Find(op.Sku_modelo);
                //op_actualizada.Numero_OP = op.Numero_OP;
                //op_actualizada.Fecha_I = op.Fecha_I;
                op_actualizada.Fecha_F = op.Fecha_F;
                //op_actualizada.num_linea = op.Num_linea;
                op_actualizada.Estado = op.Estado;
                //op_actualizada.codigo_color = op.Codigo_color;
                //op_actualizada.sku_modelo = op.Sku_modelo;
                op_actualizada.id_usuario = op.Id_usuario;
                op_actualizada.id_jornada = op.Id_jornada;
                db.SaveChanges();

            }
        }


        public ModeloOP BuscarOP(int num_op)
        {

            using (var db = new TFI_ControlCalidadEntities())
            {

                return MapearDB(db.Orden_Produccion.Find(num_op));

            }
        }
        
        private Orden_Produccion EnviarDB(ModeloOP op)
        {
            return new Orden_Produccion()
            {
                Numero_OP = op.Numero_OP,
                Fecha_I = op.Fecha_I,
                Fecha_F = op.Fecha_F,
                Estado = op.Estado,
                num_linea= op.Num_linea,
                codigo_color = op.Codigo_color,
                sku_modelo = op.Sku_modelo,
                id_usuario= op.Id_usuario,
                id_jornada= op.Id_jornada,

            };
        }

        private ModeloOP MapearDB(Orden_Produccion tabla)
        {


            return new ModeloOP()
            {
                Numero_OP = tabla.Numero_OP,
                Fecha_I = (DateTime)tabla.Fecha_I,
                Fecha_F = (DateTime)tabla.Fecha_F,
                Estado = tabla.Estado,
                Num_linea = (int)tabla.num_linea,
                Codigo_color = (int)tabla.codigo_color,
                Sku_modelo = (int)tabla.sku_modelo,
                Id_usuario = (int)tabla.id_usuario,
                Id_jornada = (int)tabla.id_jornada,
            };
        }


        /// VALIDACIONES ///
        //private ValidarOP(ModeloOP op)
        //{



        //}



    }
}
