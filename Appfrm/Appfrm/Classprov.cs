using System;
using System.Collections.Generic;
using System.Text;

namespace Appfrm
{
    internal class Classprov
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string idciudad { get; set; }

        public string toJson()
        {

            return "{\"nombre\":\"" + nombre + " \",\"telefono\": \"" + telefono + "\",\"correo\":\"" + correo + " \",\"idciudad\":\"" + idciudad + " \"}";
        }
    }
}
