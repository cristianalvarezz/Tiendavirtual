using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class Cliente
    {
        private string cedula;
        private string nombre;
        private string apellido;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string telefeno;
        private DateTime fechaRegistro;
        private string codigoCuenta;
        private string tipoId;
        private string email;

        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Telefeno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodigoCuenta { get; set; }
        public string TipoId { get; set; }
        public string Email { get; set; }

       public Cliente( string pCedula, string pNombre, string pApellido, string pDireccion, string pCiudad, string pDepartamento, 
                    string pTelefono, DateTime pFecharegistro, string pCodigocuenta, string pTipoid, string pEmail)
        {
            pCedula = cedula;
            pNombre = nombre;
            pApellido = apellido;
            pDireccion = direccion;
            pCiudad = ciudad;
            pDepartamento = departamento;
            pTelefono = telefeno;
            pFecharegistro = fechaRegistro;
            pCodigocuenta = codigoCuenta;
            pTipoid = tipoId;
            pEmail = email;
            
        }

        public Cliente()
        {
            cedula = "";
            nombre = "";
            apellido = "";
            direccion = "";
            ciudad = "";
            departamento = "";
            telefeno = "";
            codigoCuenta = "";
            tipoId = "";
            email = "";
        }


    }
}
