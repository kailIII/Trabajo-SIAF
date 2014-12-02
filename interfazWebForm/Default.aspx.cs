using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using servicioWeb;

public partial class _Default : System.Web.UI.Page
{
    public void limpiar()
    {
        txtUsuario.Text = "";
        txtPassword.Text = "";
        txtUsuario.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string password = txtPassword.Text;
        string usuario1 = txtUsuario.Text;
        
        USUARIO data = servicio.BuscarUsuarioByPasswordAndUsuario(password,usuario1);

        
        if (data == null)
        {
            lblMensaje.Text = "Usuario no encontrado";
            limpiar();
        }
        else
        {
            Session["Usuario"] = data.NOMBRE_USUARIO+" "+data.APELLIDO_USUARIO;
            Session["id_usuario"] = data.ID_USUARIO;
            Session["perfil"] = data.PERFIL;
            Response.Redirect("Principal.aspx");
        }
    }
}