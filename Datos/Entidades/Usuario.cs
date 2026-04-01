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
        public int id_rol { get; set; }
        public bool activo { get; set; }
        //datos de la persona vinculada

            
    }                                       
}
