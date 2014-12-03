<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Cliente.aspx.cs" Inherits="Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 58px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Mantenedor Cliente</p>
    <hr />

    <table class="style1">
        <tr>
            <td class="style4">
                Nombre</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Rut</td>
            <td>
                <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Telefono</td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Mail</td>
            <td>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Direccion</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnCrear" runat="server" Text="Crear" 
                    onclick="btnCrear_Click" />
            </td>
        </tr>
    </table>
    <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjMostrarTodoCliente" CellPadding="4" 
    ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Id_cliente" 
                DataNavigateUrlFormatString="ClienteModificar.aspx?id_cliente={0}" 
                DataTextField="Id_cliente" HeaderText="Modificar" Text="Modificar" />
            <asp:BoundField DataField="Nombre_cliente" HeaderText="Nombre_cliente" 
                SortExpression="Nombre_cliente" />
            <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
            <asp:BoundField DataField="Telefono_cliente" HeaderText="Telefono_cliente" 
                SortExpression="Telefono_cliente" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" />
            <asp:BoundField DataField="Direccion_cliente" HeaderText="Direccion_cliente" 
                SortExpression="Direccion_cliente" />
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
    <asp:ObjectDataSource ID="ObjMostrarTodoCliente" runat="server" 
        SelectMethod="MotrarAllCliente" TypeName="servicioWeb.WCFTrans">
    </asp:ObjectDataSource>

</asp:Content>

