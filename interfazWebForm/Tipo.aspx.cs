using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tipo : System.Web.UI.Page
{
    public void focus()
    {
        txtNombreTipo.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
    }
    protected void btnAgregaTipo_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string NOMBRE_TIPO = txtNombreTipo.Text;
        servicio.AgregarTipo(NOMBRE_TIPO);
        Response.Redirect("Tipo.aspx");
    }
}