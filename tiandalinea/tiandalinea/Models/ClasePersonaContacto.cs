using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class ClasePersonaContacto
    {
        private string nombreContacto;
        private string telefono;

        public string NombreContacto;
        public string Telefono;

        public ClasePersonaContacto( string pTelefono, string pNombreContacto)
        {
            nombreContacto = pNombreContacto;
            telefono = pTelefono;
        }

        public ClasePersonaContacto()
        {
            nombreContacto = "";
            telefono = "";
        }
    }
}
