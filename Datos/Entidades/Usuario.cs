using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {

        public int id_usuario { get; set; }
        public int id_persona { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public bool activo { get; set; }

        // --- Datos de la persona vinculada ---
        public string nombre_completo { get; set; }
        public string email { get; set; }

        // --- SEGURIDAD Y ROLES ---
        public string nombre_rol { get; set; } // <--- AGREGADO AQUÍ
        public List<string> permisos { get; set; }

        public Usuario()
        {
            permisos = new List<string>();
        }

    }                                       
}
