using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using servicioWeb;

public partial class Bodega : System.Web.UI.Page
{
    public void focus()
    {
        txtCodBodega.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string COD_BODEGA = txtCodBodega.Text;
        int ID_USUARIO = Convert.ToInt32(ddUsuario.SelectedIndex);
        servicio.AgregarBodega(COD_BODEGA,ID_USUARIO);
        Response.Redirect("Bodega.aspx");
    }
}