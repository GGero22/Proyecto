using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto
{
    public class claseRegistrar
    {
        string nombre_res;
        string password_res;
        int nivel_res;

        public string Nombre_res { get => nombre_res; set => nombre_res = value; }
        public string Password_res { get => password_res; set => password_res = value; }
        public int Nivel_res { get => nivel_res; set => nivel_res = value; }
    }
}