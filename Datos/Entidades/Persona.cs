using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Persona
    {
        public int id_persona { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public bool activo { get; set; }

        // Propiedad calculada para facilitar la UI
        public string NombreCompleto => $"{apellido}, {nombre}";
    }
}
