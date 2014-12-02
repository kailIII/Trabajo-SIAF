<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Tipo.aspx.cs" Inherits="Tipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        width: 83px;
    }
    .style3
    {
        width: 221px;
    }
    .style4
    {
        width: 128px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;</p>
<p>
    &nbsp;Mantenedor Tipo</p>
<table class="style3">
    <tr>
        <td class="style2">
            Nombre Tipo</td>
        <td class="style4">
            <asp:TextBox ID="txtNombreTipo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td class="style4">
            <asp:Button ID="btnAgregaTipo" runat="server" onclick="btnAgregaTipo_Click" 
                Text="Agrega" />
        </td>
    </tr>
</table>
<br />
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataSourceID="ObjTipo" CellPadding="4" ForeColor="#333333" 
    GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="Id_tipo" 
            DataNavigateUrlFormatString="TipoModificar.aspx?id_tipo={0}" 
            DataTextField="Id_tipo" Text="Modificar" HeaderText="Modificar" />
        <asp:BoundField DataField="Nombre_tipo" HeaderText="Nombre Tipo" 
            SortExpression="Nombre_tipo" />
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
<asp:ObjectDataSource ID="ObjTipo" runat="server" SelectMethod="MotrarAllTipo" 
    TypeName="servicioWeb.WCFTrans"></asp:ObjectDataSource>
</asp:Content>

