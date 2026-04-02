using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Soporte
{
    public static class SesionUsuario
    {
        // Solo el Login puede "Setear" el usuario, los demás solo pueden "Leerlo"
        public static Datos.Entidades.Usuario UsuarioLogueado { get;  set; }

        public static void IniciarSesion(Datos.Entidades.Usuario usuario)
        {
            UsuarioLogueado = usuario;
        }

        public static void CerrarSesion()
        {
            UsuarioLogueado = null;
        }

        public static bool TienePermiso(string nombreControl)
        {
            return UsuarioLogueado != null && UsuarioLogueado.permisos.Contains(nombreControl);
        }
    }
}
