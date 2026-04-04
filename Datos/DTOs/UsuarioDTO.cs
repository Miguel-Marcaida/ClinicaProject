using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class UsuarioDTO
    {
        // Identificadores (para poder editar o dar de baja después)
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }

        // Datos que se verán en la Grilla
        public string DNI { get; set; }
        public string NombreCompleto { get; set; } // Ejemplo: "Marcaida, Miguel"
        public string Username { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; } // Pondremos "Activo" o "Inactivo"
    }
}
