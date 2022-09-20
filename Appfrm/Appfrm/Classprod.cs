using System;
using System.Collections.Generic;
using System.Text;

namespace Appfrm
{
    internal class Classprod
    {
        public int idproducto { get; set; }
        public string nombrecomercial { get; set; }
        public string idProveedor { get; set; }
        public string idcategoria { get; set; }

        public string toJson()
        {

            return "{\"nombrecomercial\":\"" + nombrecomercial + " \",\"idProveedor\": \"" + idProveedor + "\",\"idcategoria\":\"" + idcategoria + " \"}";
        }
    }
}
