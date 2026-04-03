using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class RolFormulario
    {
        public int id_rol { get; set; }
        public int id_formulario { get; set; }

        // Propiedades de navegación (opcionales, pero útiles si querés mostrar nombres)
        // Estas no están en la tabla física, pero ayudan en la lógica de C#
        public string nombre_rol { get; set; }
        public string etiqueta_formulario { get; set; }

        public RolFormulario() { }


    }
}
