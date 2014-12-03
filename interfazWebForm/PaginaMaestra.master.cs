using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaMaestra : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["perfil"].ToString().Equals("Vendedor"))
        {
            MenuItemCollection menuItems = Menu1.Items;
            MenuItem adminItem = new MenuItem();
            
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Bodega"))
                {
                    adminItem = menuItem;
                }    
            }
            menuItems.Remove(adminItem);
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Tipo"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Producto"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Usuario"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
        }
        lblNombreUsuario.Text = Session["Usuario"].ToString();
    }
    protected void btnSalir_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}
