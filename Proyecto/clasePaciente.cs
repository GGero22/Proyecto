using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto
{
    public class clasePaciente
    {
        string nit_paciente;
        string nombre_paciente;
        string apellido_paciente;
        string direccion_paciente;
        string telefono_paciente;
        DateTime fecha_paciente;

        public string Nit_paciente { get => nit_paciente; set => nit_paciente = value; }
        public string Nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
        public string Apellido_paciente { get => apellido_paciente; set => apellido_paciente = value; }
        public string Direccion_paciente { get => direccion_paciente; set => direccion_paciente = value; }
        public string Telefono_paciente { get => telefono_paciente; set => telefono_paciente = value; }
        public DateTime Fecha_paciente { get => fecha_paciente; set => fecha_paciente = value; }
        public int edad { get { return edad_calcular(); } }
        public int edad_calcular()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - Fecha_paciente.Year;

            if (Fecha_paciente.Month > fechaActual.Month)

            {
                --edad;
            }

            return edad;
        }
    }
}