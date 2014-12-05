using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ProductosOT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string id_ot = Session["id_ot"].ToString();
        lbl_idsucursal.Text = id_ot;
    }

}