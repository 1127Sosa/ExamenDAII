using System;
using System.Collections.Generic;
using System.Text;

namespace Appfrm
{
    internal class Classpais
    {
        public int idPais { get; set; }
        public string nombre_pais { get; set; }
        public string codigo_de_area { get; set; }

        public string toJson()
        {

            return "{\"nombre_pais\":\"" + nombre_pais + " \",\"codigo_de_area\": \"" + codigo_de_area + "\"}";
        }
    }
}

