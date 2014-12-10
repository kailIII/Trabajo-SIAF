using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductosOTEliminar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id_producto_ot = Convert.ToString(Request.QueryString["id_producto_ot"]);
        lbl_idproductoot.Text = id_producto_ot;
        lbl_idot.Text = Session["id_ot"].ToString();
       
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        int ID_OT = int.Parse(lbl_idot.Text);
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();
        int ID_PRODUCTO_OT = int.Parse(lbl_idproductoot.Text);
        servicio.BorrarProductoOTBYIDPRODUCTOOT(ID_PRODUCTO_OT);

        Response.Redirect("ProductosOT.aspx?id_ot=" + ID_OT + "");
    }
}