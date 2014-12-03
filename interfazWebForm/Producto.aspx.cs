using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Producto : System.Web.UI.Page
{
    private void focus()
    {
        txtCodPro.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string COD_PRODUCTO = txtCodPro.Text;
        int ID_TIPO = Convert.ToInt32(ddTipo.SelectedIndex);
        string COD_BODEGA = Convert.ToString(ddCodBodega.SelectedValue);
        string NOMBRE_PRODUCTO= txtNomProd.Text;
        string COD_BARRA = "xxx";
        servicio.AgregarProducto(COD_PRODUCTO, ID_TIPO, COD_BODEGA, NOMBRE_PRODUCTO, COD_BARRA);
        Response.Redirect("Producto.aspx");
    }
}