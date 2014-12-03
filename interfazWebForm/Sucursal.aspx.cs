using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sucursal : System.Web.UI.Page
{
    public void focus()
    {
        txtDireccion.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string DIRECCION_SUCURSAL = txtDireccion.Text;
        int TELEFONO_SUCURSAL = Convert.ToInt32(txtTelefono.Text);
        servicio.AgregarSucursal(DIRECCION_SUCURSAL,TELEFONO_SUCURSAL);
        Response.Redirect("Sucursal.aspx");
    }
}