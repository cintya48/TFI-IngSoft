using Datos;
using Negocio.Interfaces;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorio
{
    public class RepoUsuario : IRepoUsuario
    {
      
        ModeloUsuario IRepoUsuario.ObtenerUsuario(string username, string password)
        {

            using (var context = new TFI_ControlCalidadEntities())
            {
                var usuario = context.Usuario.FirstOrDefault(u => u.Email == username && u.Contraseña == password);
                var user = new ModeloUsuario
                {
                    Email = usuario.Email,
                    Contraseña = usuario.Contraseña,
                    Nombre_Apellido = usuario.Nombre_Apellido,
                    Rol = usuario.Rol,
                    Legajo = usuario.Legajo,


                };
                return user;
            }

        }
    }

}
