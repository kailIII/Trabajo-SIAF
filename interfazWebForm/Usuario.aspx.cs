using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuario : System.Web.UI.Page
{
    public void focus()
    {
        txtNUsuario.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string USUARIO1 = txtNUsuario.Text;
        string PASSWORD = txtPassword.Text;
        int ID_SUCURSAL = Convert.ToInt32(ddSucursal.SelectedValue);
        string PERFIL = ddPerfil.SelectedValue;
        string NOMBRE_USUARIO = txtNombre.Text;
        string APELLIDO_USUARIO = txtApellido.Text;
        servicio.AgregarUsuario(ID_SUCURSAL,PASSWORD,PERFIL,NOMBRE_USUARIO,APELLIDO_USUARIO,USUARIO1);
        Response.Redirect("Usuario.aspx");
    }
}