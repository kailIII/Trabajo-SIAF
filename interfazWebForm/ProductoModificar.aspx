<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ProductoModificar.aspx.cs" Inherits="ProductoModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Modificar Producto</p>
    <hr />
    <p>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        CellPadding="4" DataSourceID="ObjModificarProducto" ForeColor="#333333" 
        GridLines="None" Height="50px" Width="125px">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="PRODUCTO_COD" HeaderText="PRODUCTO_COD" 
                SortExpression="PRODUCTO_COD" />
            <asp:BoundField DataField="ID_TIPO" HeaderText="ID_TIPO" 
                SortExpression="ID_TIPO" />
            <asp:BoundField DataField="COD_BODEGA" HeaderText="COD_BODEGA" 
                SortExpression="COD_BODEGA" />
            <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="NOMBRE_PRODUCTO" 
                SortExpression="NOMBRE_PRODUCTO" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjModificarProducto" runat="server" 
        SelectMethod="MostrarProductoByID" TypeName="servicioWeb.WCFTrans" 
        UpdateMethod="ModificarProducto">
        <SelectParameters>
            <asp:QueryStringParameter Name="PRODUCTO_COD" QueryStringField="id_producto" 
                Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="PRODUCTO_COD" Type="String" />
            <asp:Parameter Name="ID_TIPO" Type="Int32" />
            <asp:Parameter Name="COD_BODEGA" Type="String" />
            <asp:Parameter Name="NOMBRE_PRODUCTO" Type="String" />
            <asp:Parameter Name="COD_BARRA" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</p>
</asp:Content>

