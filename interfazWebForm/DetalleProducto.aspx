<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="DetalleProducto.aspx.cs" Inherits="DetalleProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 175px;
        }
        .style7
        {
            width: 313px;
        }
        .style8
        {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Detalle Producto</p>
    <hr />

    <table class="style7">
        <tr>
            <td class="style6">
                CODIGO DETALLE</td>
            <td class="style8">
                <asp:TextBox ID="txtCodDetalle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                CODIGO DE PRODUCTO</td>
            <td class="style8">
                <asp:Label ID="lblCodPro" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                CANTIDAD MINIMA</td>
            <td class="style8">
                <asp:TextBox ID="txtCanMin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                CANTIDAD ACTUAL</td>
            <td class="style8">
                <asp:TextBox ID="txtCanAct" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                VALOR</td>
            <td class="style8">
                <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style8">
                <asp:Button ID="btnCrear" runat="server" Text="Crear" 
                    onclick="btnCrear_Click" />
            </td>
        </tr>
    </table>
    <hr />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjMostrarTodoDetalle" AllowPaging="True" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="Producto_cod_detalle" 
                HeaderText="Producto_cod_detalle" SortExpression="Producto_cod_detalle" />
            <asp:BoundField DataField="Producto_cod" HeaderText="Producto_cod" 
                SortExpression="Producto_cod" />
            <asp:BoundField DataField="Cantidad_minima" HeaderText="Cantidad_minima" 
                SortExpression="Cantidad_minima" />
            <asp:BoundField DataField="Cantidad_actual" HeaderText="Cantidad_actual" 
                SortExpression="Cantidad_actual" />
            <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
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
    <asp:ObjectDataSource ID="ObjMostrarTodoDetalle" runat="server" 
        SelectMethod="MotrarAllDetalle" TypeName="servicioWeb.WCFTrans" 
        UpdateMethod="ModificarDetalle">
        <UpdateParameters>
            <asp:Parameter Name="PRODUCTO_COD_DETALLE" Type="String" />
            <asp:Parameter Name="PRODUCTO_COD" Type="String" />
            <asp:Parameter Name="CANTIDAD_MINIMA" Type="Int32" />
            <asp:Parameter Name="CANTIDAD_ACTUAL" Type="Int32" />
            <asp:Parameter Name="VALOR" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

