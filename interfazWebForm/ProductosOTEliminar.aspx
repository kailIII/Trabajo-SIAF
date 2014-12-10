<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ProductosOTEliminar.aspx.cs" Inherits="ProductosOTEliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Eliminar Productos de la OT</p>
    <hr />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataSourceID="ObjectEliminarProductoOT" Height="50px" Width="216px" 
    CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="ID_PRODUCTO_OT" HeaderText="ID Producto" 
                SortExpression="ID_PRODUCTO_OT" />
            <asp:BoundField DataField="PRODUCTO_COD" HeaderText="Codigo Producto" 
                SortExpression="PRODUCTO_COD" />
            <asp:BoundField DataField="ID_OT" HeaderText="Numero OT" 
                SortExpression="ID_OT" />
            <asp:BoundField DataField="CANTIDAD" HeaderText="Cantidad" 
                SortExpression="CANTIDAD" />
            <asp:BoundField DataField="VALOR_TOTAL" HeaderText="Valor Total" 
                SortExpression="VALOR_TOTAL" />
           
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectEliminarProductoOT" runat="server" 
        SelectMethod="MostrarProductosOtByID" TypeName="servicioWeb.WCFTrans">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID_PRODUCTO_OT" 
                QueryStringField="id_producto_ot" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
        Text="Eliminar" />
    <br />
    <asp:Label ID="lbl_idproductoot" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lbl_idot" runat="server" Visible="False"></asp:Label>
</asp:Content>

