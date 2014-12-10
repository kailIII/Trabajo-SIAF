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

        lblNombreUsuario.Text = Session["Usuario"].ToString();

        //vendedor
        
        if (Session["perfil"].ToString().Equals("Vendedor"))
        {
            MenuItemCollection menuItems = Menu1.Items;
            MenuItem adminItem = new MenuItem();
            //item bodega vendedor
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Bodega"))
                {
                    adminItem = menuItem;
                }    
            }
            menuItems.Remove(adminItem);
            //item tipo vendedor
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Tipo"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            //item producto vendedor
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Producto"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            //item usuario vendedor
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Usuario"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            //item informe bodega vendedor
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Informe Bodega"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
        }

        //bodega

        if (Session["perfil"].ToString().Equals("Bodegero"))
        {
            MenuItemCollection menuItems = Menu1.Items;
            MenuItem adminItem = new MenuItem();

            //item cliente bodega
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Cliente"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            //item ot bodega
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Crear OT"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            //item usuario bodega
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Usuario"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
            //item bodega bodega
            foreach (MenuItem menuItem in menuItems)
            {

                if ((menuItem.Text == "Bodega"))
                {
                    adminItem = menuItem;
                }
            }
            menuItems.Remove(adminItem);
        }
        
    }
    protected void btnSalir_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}
