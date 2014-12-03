<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Sucursal.aspx.cs" Inherits="Sucursal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Mantenedor Sucursal</p>
    <hr />
    <br />
    <table class="style1">
        <tr>
            <td>
                Direccion
            </td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Telefono</td>
            <td style="margin-left: 40px">
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="margin-left: 40px">
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

