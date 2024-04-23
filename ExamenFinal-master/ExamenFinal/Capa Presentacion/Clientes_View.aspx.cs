using ExamenFinal.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Clientes_View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarLista();
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

        private void cargarLista()
        {
            Cliente_OP cliente = new Cliente_OP();
            listaClientes.DataSource = cliente.ObtenerClientes();
            listaClientes.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente_OP cliente = new Cliente_OP();
            cliente.AgregarCliente(nombre.Text, email.Text, telefono.Text);
            limpiar();
            cargarLista();
        }
        protected void btnBorrar_Click(object sender, EventArgs e)
        {           
            Cliente_OP cliente_OP = new Cliente_OP();
            cliente_OP.BorrarCliente(Int32.Parse(idBorrar.Text));
            limpiar();
            cargarLista();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {            
            Cliente_OP cliente_OP = new Cliente_OP();
            cliente_OP.ModificarCliente(Int32.Parse(idModificar.Text), nombreModificar.Text, emailModificar.Text, telefonoModificar.Text);
            limpiar();
            cargarLista();
        }
    }
}