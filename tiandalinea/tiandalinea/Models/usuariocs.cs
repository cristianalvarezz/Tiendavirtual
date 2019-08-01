using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiandalinea.Models
{
    public class usuariocs
    {
        private string login;
        private string contrasena;

        public string Login { set; get; }
        public string Contrasena { set; get; }


        public usuariocs(string plogin, string pcontrasena)
        {
            login = pcontrasena;
            

        }


    }
}
