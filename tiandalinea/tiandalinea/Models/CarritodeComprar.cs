using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class CarritodeComprar
    {
        private string idCarrito;
        private int suTotal;

        public string IdCarrito { set; get; }
        public int SuTotal { set; get; }

        public CarritodeComprar( string pIdcarrito, int pSutotal)
        {
            idCarrito = pIdcarrito;
            suTotal = pSutotal;
        }

        public CarritodeComprar()
        {
            idCarrito = "";
            suTotal = 0;
        }
    }

  
}
