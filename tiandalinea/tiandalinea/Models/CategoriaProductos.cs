using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class CategoriaProductos
    {
        private string categoria;
        private string nombreProducto;
        private string descripcion;
        private string  imagen;
        public string Categoria { set; get; }
        public string NombreProducto { set; get; }
        public string Descripcion { set; get; }
        public string Imagen { set; get; }


        public CategoriaProductos(string pCategoria, string pNombreProducto, string pDescripcion,string pImagen)
        {
            pCategoria = categoria;

            pNombreProducto  = nombreProducto;

            pDescripcion = descripcion;
            pImagen = imagen;

        }
        public CategoriaProductos()
        {
            categoria ="";

            nombreProducto = "";

            descripcion = "";
            imagen = "";
        }
    }
}
