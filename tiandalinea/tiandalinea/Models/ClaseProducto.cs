﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class ClaseProducto
    {
        private string descripcion;
        private string idProducto;
        private string imagen;
        private string nombre;
        private string precioUnitario;
        private bool suspendido;

        public string Descripcion { set; get; } 
        public string IdProducto { set; get; }
        public string Imagen { set; get; }
        public string Nombre { set; get; }
        public string PrecioUnitario { set; get; }
        public bool Suspendido { set; get; }

        public ClaseProducto( string pDescripcion, string pIdProducto, string  pImagen, string pNombre, string pPrecioUnitario,
                            bool pSuspendido)
        {
            descripcion = pDescripcion;
            idProducto = pIdProducto;
            imagen = pImagen;
            nombre = pNombre;
            precioUnitario = pPrecioUnitario;
            suspendido = pSuspendido;

        }
    }
}
