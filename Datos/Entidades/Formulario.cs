using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Formulario
    {
        public int id_formulario { get; set; }
        public string nombre_control { get; set; } // El que coincide con el Name del botón
        public string etiqueta { get; set; }       // El texto que lee el humano
        public bool activo { get; set; }
    }
}
