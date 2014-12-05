<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Sucursal.aspx.cs" Inherits="Sucursal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 58px;
        }
        .style7
        {
            width: 196px;
        }
        .style8
        {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Mantenedor Sucursal</p>
    <hr />
    <br />
    <table class="style7">
        <tr>
            <td class="style6">
                Direccion
            </td>
            <td class="style8">
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Telefono</td>
            <td style="margin-left: 40px" class="style8">
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td style="margin-left: 40px" class="style8">
                <asp:Button ID="btnCrear" runat="server" Text="Crear" 
                    onclick="btnCrear_Click" />
            </td>
        </tr>
    </table>
    <hr />
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    CellPadding="4" DataSourceID="objMuestraTodoCliente" ForeColor="#333333" 
    GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="Id_sucursal" 
            DataNavigateUrlFormatString="SucursalModificar.aspx?id_sucursal={0}" 
            DataTextField="Id_sucursal" HeaderText="Modificar" Text="Modificar" />
        <asp:BoundField DataField="Direccion_sucursal" HeaderText="Direccion_sucursal" 
            SortExpression="Direccion_sucursal" />
        <asp:BoundField DataField="Telefono_sucursal" HeaderText="Telefono_sucursal" 
            SortExpression="Telefono_sucursal" />
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
<asp:ObjectDataSource ID="objMuestraTodoCliente" runat="server" 
    SelectMethod="MotrarAllSucursal" TypeName="servicioWeb.WCFTrans">
</asp:ObjectDataSource>
</asp:Content>

