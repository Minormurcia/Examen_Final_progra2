using ExamenFinal.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Login_OP login = new Login_OP();
            if (login.ObtenerUsuario(username.Text, password.Text) == true)
            {
                Response.Redirect("Menuprincipal.aspx");
            }
            else
            {
                Response.Write("<Script>alert('Usuario no existe)</Script>");
            }
        }
    }
}