<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Bodega.aspx.cs" Inherits="Bodega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style3
    {
        width: 130px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Mantenedor Bodega</p>
    <hr />
<table class="style1">
    <tr>
        <td class="style3">
            CODIGO BODEGA</td>
        <td>
            <asp:TextBox ID="txtCodBodega" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            USUARIO</td>
        <td>
            <asp:DropDownList ID="ddUsuario" runat="server" DataSourceID="ObjectAllUsuario" 
                DataTextField="Nombre_usuario" DataValueField="Id_usuario">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectAllUsuario" runat="server" 
                SelectMethod="MotrarAllUsuarios" TypeName="servicioWeb.WCFTrans">
            </asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            <asp:Button ID="btnAgregar" runat="server" Text="Crear" 
                onclick="btnAgregar_Click" />
        </td>
    </tr>
</table>
<hr />
    <p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectMostrarAllBodega" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Cod_bodega" 
                DataNavigateUrlFormatString="BodegaModificar.aspx?id_bodega={0}" 
                DataTextField="Cod_bodega" HeaderText="Modificar" Text="Modificar" />
            <asp:BoundField DataField="Cod_bodega" HeaderText="Cod_bodega" 
                SortExpression="Cod_bodega" />
            <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" 
                SortExpression="Id_Usuario" />
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
    <asp:ObjectDataSource ID="ObjectMostrarAllBodega" runat="server" 
        SelectMethod="MotrarAllBodega" TypeName="servicioWeb.WCFTrans">
    </asp:ObjectDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>

