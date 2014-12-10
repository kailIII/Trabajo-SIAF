using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSiguiente_Click(object sender, EventArgs e)
    {
        servicioWeb.WCFTrans servicio = new servicioWeb.WCFTrans();

        int ID_CLIENTE = Convert.ToInt32(ddCliente.SelectedValue);
        int ID_SUCURSAL = Convert.ToInt32(ddSucursal.SelectedValue);
        DateTime FECHA_OT = DateTime.Now;
        int NETO_OT = 0;
        string ESTADO = "Activa";
        int id_ot = servicio.AgregarOt(ID_SUCURSAL, ID_CLIENTE, NETO_OT, FECHA_OT, ESTADO);
        Response.Redirect("ProductosOT.aspx?id_ot="+id_ot+"");
    }
}