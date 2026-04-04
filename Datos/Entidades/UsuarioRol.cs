using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class UsuarioRol
    {
        // Generalmente estas tablas no llevan un ID autoincremental propio, 
        // sino una clave primaria compuesta por ambos IDs.

        public int id_usuario { get; set; }
        public int id_rol { get; set; }

        // Propiedades de navegación (opcionales, útiles si usas algún ORM o para mostrar nombres)
        public string nombre_usuario { get; set; }
        public string nombre_rol { get; set; }

        // Fecha de asignación (opcional, por si querés saber cuándo se le dio el rol)
        public DateTime? fecha_asignacion { get; set; }
    }
}
