using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto
{
    public partial class Secretaria : System.Web.UI.Page
    {

        
            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                //registar pacientes
                if (DropDownList1.SelectedIndex == 0)
                    Response.Redirect("Paciente.aspx", true);
                if (DropDownList1.SelectedIndex == 1)
                    Response.Redirect("Cita.aspx", true);
                else
                    Response.Write("<script>alert('Seleccione una opcion')</script>");
            }
        }
    }
