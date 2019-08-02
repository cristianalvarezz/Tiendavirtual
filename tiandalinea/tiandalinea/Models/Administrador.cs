using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class Administrador
    {
        private string nombre;
        private string apellido;
        private string telefono;
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
       

        public Administrador(string pNombre, string pApellido,  string pTelefono)
        {
            pNombre = nombre;

            pApellido = apellido;
            
            pTelefono = telefono;


        }
        public Administrador()
        {
            Nombre = "";
            apellido = "";
            
            Telefono = "";
        }
    }
}
