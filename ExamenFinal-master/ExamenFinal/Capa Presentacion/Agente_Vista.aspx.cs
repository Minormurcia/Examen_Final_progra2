using ExamenFinal.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Agente_Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void cargarLista()
        {
            Agente_OP agente = new Agente_OP();
            listaAgentes.DataSource = agente.ObtenerAgentes();
            listaAgentes.DataBind();
        }

        protected void limpiar()
        {
            nombre.Text = "";
            email.Text = "";
            telefono.Text = "";
            idBorrar.Text = "";
            idModificar.Text = "";
            nombreModificar.Text = "";
            emailModificar.Text = "";
            telefonoModificar.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Agente_OP agente = new Agente_OP();
            agente.AgregarAgente(nombre.Text, email.Text, telefono.Text);
            limpiar();
            cargarLista();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            Agente_OP agente = new Agente_OP();
            agente.BorrarAgente(Int32.Parse(idBorrar.Text));
            limpiar();
            cargarLista();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Agente_OP agente = new Agente_OP();
            agente.ModificarAgente(Int32.Parse(idModificar.Text), nombreModificar.Text, emailModificar.Text, telefonoModificar.Text);
            limpiar();
            cargarLista();
        }
    }
}