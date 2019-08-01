using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class Vendedor
    {
        private string nombre;
        private string direccion;
        private string ciudad;
        private string telefono;
        private string email;

        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string  Email { set; get; }
        public string Ciudad { set; get; }

        public Vendedor(string pNombre,  string pDireccion, string pCiudad,  string pEmail,string pTelefono)
        {
            pNombre = nombre;
            
            pDireccion = direccion;
            pCiudad = ciudad;
            pEmail = email;
            pTelefono = telefono;


        }
        public Vendedor()
        {
            Nombre = "";
            Direccion = "";
            Ciudad = "";
            Email = "";
            Telefono = "";
        }



    }
}
