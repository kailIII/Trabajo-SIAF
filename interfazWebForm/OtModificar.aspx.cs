using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OtModificar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        int ID_OT = int.Parse(ddOT.SelectedValue);
        Response.Redirect("ProductosOT.aspx?id_ot=" + ID_OT + "");
    }
}