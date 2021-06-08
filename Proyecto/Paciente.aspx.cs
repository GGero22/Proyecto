using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto
{
    public partial class Paciente : System.Web.UI.Page
    {

        
            static List<clasePaciente> array_paciente = new List<clasePaciente>();
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    string archivo = Server.MapPath("Paciente.json");

                    if (File.Exists(archivo))
                    {
                        StreamReader jsonStream = File.OpenText(archivo);
                        string json = jsonStream.ReadToEnd();
                        jsonStream.Close();
                        if (json.Length > 0)
                        {
                            array_paciente = JsonConvert.DeserializeObject<List<clasePaciente>>(json);
                        }
                    }
                }

            }
            private void Guardar()
            {
                string json = JsonConvert.SerializeObject(array_paciente);
                string archivo = Server.MapPath("Paciente.json");
                System.IO.File.WriteAllText(archivo, json);

            }

            protected void Button1_Click1(object sender, EventArgs e)
            {
                clasePaciente pac = new clasePaciente();

                pac.Nit_paciente = TextBox1.Text;
                pac.Nombre_paciente = TextBox2.Text;
                pac.Apellido_paciente = TextBox3.Text;
                pac.Direccion_paciente = TextBox4.Text;
                pac.Telefono_paciente = TextBox5.Text;
                pac.Fecha_paciente = Calendar1.SelectedDate;
                array_paciente.Add(pac);

                Guardar();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
            }

            protected void Button2_Click(object sender, EventArgs e)
            {
                Response.Redirect("Cita.asp", true);
            }
        }
    }
