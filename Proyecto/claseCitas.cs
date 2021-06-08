using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto
{
    public class claseCitas
    {
        string nit_agenda;
        DateTime fecha_agenda;
        string hora_inicio;
        string hora_final;

        public string Nit_agenda { get => nit_agenda; set => nit_agenda = value; }
        public DateTime Fecha_agenda { get => fecha_agenda; set => fecha_agenda = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_final { get => hora_final; set => hora_final = value; }
    }
}