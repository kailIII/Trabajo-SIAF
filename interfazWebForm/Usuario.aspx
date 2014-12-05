<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Usuario.aspx.cs" Inherits="Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 102px;
        }
        .style7
        {
            width: 309px;
        }
        .style8
        {
            width: 197px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Mantenedor Usuario</p>
        <hr />
    <table class="style7">
        <tr>
            <td class="style6">
                Sucursal</td>
            <td class="style8">
                <asp:DropDownList ID="ddSucursal" runat="server" DataSourceID="ObjSucursales" 
                    DataTextField="Direccion_sucursal" DataValueField="Id_sucursal">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjSucursales" runat="server" 
                    SelectMethod="MotrarAllSucursal" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Nombre Usuario</td>
            <td class="style8">
                <asp:TextBox ID="txtNUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Password</td>
            <td class="style8">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Nombre
            </td>
            <td class="style8">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Apellido</td>
            <td class="style8">
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Perfil</td>
            <td class="style8">
                <asp:DropDownList ID="ddPerfil" runat="server">
                    <asp:ListItem Value="0">Seleccione</asp:ListItem>
                    <asp:ListItem Value="admin">Administrador</asp:ListItem>
                    <asp:ListItem>Vendedor</asp:ListItem>
                    <asp:ListItem>Bodegero</asp:ListItem>
                    <asp:ListItem>Demo</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style8">
                <asp:Button ID="btnCrear" runat="server" Text="Agregar" 
                    onclick="btnCrear_Click" />
            </td>
        </tr>
    </table>
    <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    CellPadding="4" DataSourceID="ObjMostrarTodoCliente" ForeColor="#333333" 
    GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Id_usuario" 
                DataNavigateUrlFormatString="UsuarioModificar.aspx?id_usuario={0}" 
                DataTextField="Id_usuario" HeaderText="Modificar" Text="Modificar" />
            <asp:BoundField DataField="Id_usuario" HeaderText="Id_usuario" 
                SortExpression="Id_usuario" />
            <asp:BoundField DataField="Id_sucursal" HeaderText="Id_sucursal" 
                SortExpression="Id_sucursal" />
            <asp:BoundField DataField="Password" HeaderText="Password" 
                SortExpression="Password" />
            <asp:BoundField DataField="Perfil" HeaderText="Perfil" 
                SortExpression="Perfil" />
            <asp:BoundField DataField="Nombre_usuario" HeaderText="Nombre_usuario" 
                SortExpression="Nombre_usuario" />
            <asp:BoundField DataField="Apellido_usuario" HeaderText="Apellido_usuario" 
                SortExpression="Apellido_usuario" />
            <asp:BoundField DataField="Usuario1" HeaderText="Usuario1" 
                SortExpression="Usuario1" />
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
    SelectMethod="MotrarAllUsuarios" TypeName="servicioWeb.WCFTrans">
</asp:ObjectDataSource>
</asp:Content>

