<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Bodega.aspx.cs" Inherits="Bodega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Mantenedor Bodega</p>
<table class="style1">
    <tr>
        <td>
            CODIGO BODEGA</td>
        <td>
            <asp:TextBox ID="txtCodBodega" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="btnAgregar" runat="server" Text="Crear" 
                onclick="btnAgregar_Click" />
        </td>
    </tr>
</table>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectMostrarAllBodega">
        <Columns>
            <asp:BoundField DataField="Cod_bodega" HeaderText="Cod_bodega" 
                SortExpression="Cod_bodega" />
            <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" 
                SortExpression="Id_Usuario" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectMostrarAllBodega" runat="server" 
        SelectMethod="MotrarAllBodega" TypeName="servicioWeb.WCFTrans">
    </asp:ObjectDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>

