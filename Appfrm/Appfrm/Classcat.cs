using System;
using System.Collections.Generic;
using System.Text;

namespace Appfrm
{
    internal class Classcat
    {
        public int idcategoria { get; set; }
        public string nombre { get; set; }
        public string abreviacion { get; set; }

        public string toJson()
        {

            return "{\"nombre\":\"" + nombre + " \",\"abreviacion\": \"" + abreviacion + "\"}";
        }
    }
}
