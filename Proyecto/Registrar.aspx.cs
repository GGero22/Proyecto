using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BC = BCrypt.Net.BCrypt;

namespace Proyecto
{
    public partial class Registrar : System.Web.UI.Page
    {

        
            static List<claseRegistrar> array_registrar = new List<claseRegistrar>();
            protected void Page_Load(object sender, EventArgs e)
            {
                var identidad = (FormsIdentity)Context.User.Identity;

                if (identidad.Ticket.UserData == "1")
                {
                    string archivo = Server.MapPath("Json_Registro.json");
                    if (File.Exists(archivo))
                    {
                        StreamReader jsonStream = File.OpenText(archivo);
                        string json = jsonStream.ReadToEnd();
                        jsonStream.Close();

                        array_registrar = JsonConvert.DeserializeObject<List<claseRegistrar>>(json);
                    }
                }
                else
                    Response.Redirect("AbrirSesion/CerrarSesion", true);

            }
            private void Guardar()
            {
                string json = JsonConvert.SerializeObject(array_registrar);
                string archivo = Server.MapPath("Json_Registro.json");
                System.IO.File.WriteAllText(archivo, json);

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                claseRegistrar tempo_res = new claseRegistrar();

                tempo_res.Nombre_res = TextBox1.Text;
                string miPassword = TextBox1.Text;
                string miSal = BC.GenerateSalt();
                string miHash = BC.HashPassword(miPassword, miSal);
                tempo_res.Password_res = miHash;
                tempo_res.Nivel_res = Convert.ToInt32(RadioButtonList1.SelectedValue);

                array_registrar.Add(tempo_res);

                Guardar();
            }
        }
    }
