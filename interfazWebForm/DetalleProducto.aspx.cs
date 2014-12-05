using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using servicioWeb;

public partial class DetalleProducto : System.Web.UI.Page
{
    public void focus()
    {
        txtCodDetalle.Focus();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        focus();
        string PRODUCTO_COD = Convert.ToString(Request.QueryString["id_producto"]);
        lblCodPro.Text = PRODUCTO_COD.ToString();
    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        string PRODUCTO_COD = lblCodPro.Text;
        string PRODUCTO_COD_DETALLE = txtCodDetalle.Text;
        int CANTIDAD_MINIMA = Convert.ToInt32( txtCanMin.Text);
        int CANTIDAD_ACTUAL = Convert.ToInt32(txtCanAct.Text);
        int VALOR = Convert.ToInt32(txtValor.Text);
        servicio.AgregarDetalle(PRODUCTO_COD_DETALLE,PRODUCTO_COD,CANTIDAD_MINIMA,CANTIDAD_ACTUAL,VALOR);
        Response.Redirect("DetalleProducto.aspx?id_producto="+PRODUCTO_COD+"");
    }
}