using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class Pedido
    {
        private string idPedido;
        private DateTime fechaPedido;
        private DateTime fechaEntrega;
        private string direccionEntrega;
        private string sitioEntrega;
        private string codPostalEntrega;
        private int recargo;
        private int total;
        private int descuento;
        private int pagado;

        public string IdPedido { set; get; }
        public string FechaPedido { set; get; }
        public string FechaEntrega { set; get; }
        public string DireccionEntrega { set; get; }
        public string SitioEntrega { set; get; }
        public string CodPostalEntrega { set; get; }
        public string Recargo { set; get; }
        public string Total { set; get; }

        public string Descuento { set; get; }
        public string Pagado { set; get; }
        


        public Pedido(string pIdPedido, string pFechaPedido, DateTime pFechaEntrega, string pDireccionEntrega, string pSitioEntrega, string pCodPostalEntrega, int pRecargo, int pTotal, int pPagado,int pDescuento)
        {
             pIdPedido=idPedido;
            pFechaEntrega=fechaEntrega;
            pDireccionEntrega = direccionEntrega;
            pSitioEntrega= sitioEntrega;
            pCodPostalEntrega=codPostalEntrega;
            pRecargo=recargo;
            pTotal=total;
            pDescuento= descuento;
            pPagado= pagado;

    }
        public Pedido()
        {
            idPedido=""; 
            direccionEntrega="";
            sitioEntrega="";
            CodPostalEntrega = "";
            recargo=0;
            total=0;
            descuento=0;
            pagado=0;

        }
    }
}

