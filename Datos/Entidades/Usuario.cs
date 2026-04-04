using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario:Persona
    {

        public int id_usuario { get; set; }
        // id_persona ya lo trae de la clase base (Persona)

        public string username { get; set; }
        public string password_hash { get; set; }

        // Usamos 'new' si queremos que el 'activo' del login 
        // sea independiente del 'activo' de la persona física.
        public new bool activo { get; set; }

        // --- SEGURIDAD Y ROLES ---
        public string nombre_rol { get; set; }
        public List<string> permisos { get; set; }

        public Usuario()
        {
            permisos = new List<string>();
        }

    }                                       
}
