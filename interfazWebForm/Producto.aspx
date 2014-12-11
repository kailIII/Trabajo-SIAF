<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Producto.aspx.cs" Inherits="Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 111px;
        }
        .style4
        {
            width: 342px;
        }
        .style5
        {
            width: 221px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Mantenedor Producto</p>
    <hr />
    <table class="style4">
        <tr>
            <td class="style3">
                Codigo Producto</td>
            <td class="style5" style="margin-left: 80px">
                <asp:TextBox ID="txtCodPro" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Tipo
            </td>
            <td class="style5">
                <asp:DropDownList ID="ddTipo" runat="server" 
                    DataSourceID="ObjMostrarTodoTipo" DataTextField="Nombre_tipo" 
                    DataValueField="Id_tipo">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjMostrarTodoTipo" runat="server" 
                    SelectMethod="MotrarAllTipo" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Codigo Bodega</td>
            <td class="style5">
                <asp:DropDownList ID="ddCodBodega" runat="server" 
                    DataSourceID="objMostrarBodega" DataTextField="Cod_bodega" 
                    DataValueField="Cod_bodega">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="objMostrarBodega" runat="server" 
                    SelectMethod="MotrarAllBodega" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Nombre Producto</td>
            <td class="style5">
                <asp:TextBox ID="txtNomProd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="btnCrear" runat="server" onclick="btnCrear_Click" 
                    Text="Crear" />
            </td>
        </tr>
    </table>
    <hr />
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="objMuestraTodoProducto" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Producto_cod" 
                DataNavigateUrlFormatString="ProductoModificar.aspx?id_producto={0}" 
                DataTextField="Producto_cod" HeaderText="Modificar Producto" 
                Text="Modificar Producto" />
            <asp:BoundField DataField="Producto_cod" HeaderText="Codigo Producto" 
                SortExpression="Producto_cod" />
            <asp:BoundField DataField="Cod_bodega" HeaderText="Codigo Bodega" 
                SortExpression="Cod_bodega" />
            <asp:BoundField DataField="Nombre_producto" HeaderText="Nombre Producto" 
                SortExpression="Nombre_producto" />
            <asp:HyperLinkField DataNavigateUrlFields="Producto_cod" 
                DataNavigateUrlFormatString="DetalleProducto.aspx?id_producto={0}" 
                DataTextField="Producto_cod" HeaderText="Detalle Producto" 
                Text="Detalle Producto" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:ObjectDataSource ID="objMuestraTodoProducto" runat="server" 
        SelectMethod="MotrarAllProducto" TypeName="servicioWeb.WCFTrans">
    </asp:ObjectDataSource>
    </p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>

