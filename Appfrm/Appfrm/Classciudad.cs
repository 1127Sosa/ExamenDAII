using System;
using System.Collections.Generic;
using System.Text;

namespace Appfrm
{
    internal class Classciudad
    {
        public int idciudad { get; set; }
        public string idPais { get; set; }
        public string nombre_ciudad { get; set; }

        public string toJson()
        {

            return "{\"idPais\":\"" + idPais + " \",\"nombre_ciudad\": \"" + nombre_ciudad + "\"}";
        }
    }
}
