using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using servicioWeb;
public partial class ProductosOT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string id_ot = Convert.ToString(Request.QueryString["id_ot"]);
        lbl_idot.Text = id_ot;
        Session["id_ot"] = lbl_idot.Text;
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        /*ProductosOT.aspx?id_ot=1*/
        int ID_OT = Convert.ToInt32(lbl_idot.Text);
        string PRODUCTO_COD = dd_productoCod.SelectedValue;
        int CANTIDAD = Convert.ToInt32(txtCantidad.Text);

        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        DETALLE detalle = servicio.MostrarDetalleByIDProducto(PRODUCTO_COD);

        int VALOR_DEL_PRODUCTO = int.Parse(detalle.VALOR.ToString());
        int TOTAL_PRODUCTO = CANTIDAD * VALOR_DEL_PRODUCTO;

        servicio.AgregarProductoOt(PRODUCTO_COD,ID_OT,CANTIDAD,TOTAL_PRODUCTO);

        Response.Redirect("ProductosOT.aspx?id_ot="+ID_OT+"");
    }
}