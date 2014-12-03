using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente : System.Web.UI.Page
{
    public void focus()
    {
        txtNombre.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string NOMBRE_CLIENTE = txtNombre.Text;
        string RUT = txtRut.Text;
        int TELEFONO_CLIENTE = Convert.ToInt32(txtTelefono.Text);
        string MAIL = txtMail.Text;
        string DIRECCION_CLIENTE = txtDireccion.Text;
        servicio.AgregarCliente(NOMBRE_CLIENTE,RUT,TELEFONO_CLIENTE,MAIL,DIRECCION_CLIENTE);
        Response.Redirect("Cliente.aspx");
    }
}