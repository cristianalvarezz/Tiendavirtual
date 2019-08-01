using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class Cliente
    {
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

       public Cliente ( string pnombre, string papellido, string pdireccion, string pciudad, string pdepartamento, 
                    string ptelefono, DateTime pfecharegistro, string pcodigocuenta, string ptipoid, string Email)
        {

        }


    }
}
