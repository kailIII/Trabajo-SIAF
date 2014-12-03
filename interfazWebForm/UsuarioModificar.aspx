<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="UsuarioModificar.aspx.cs" Inherits="UsuarioModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Modificar Usuario</p>
    <hr />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        CellPadding="4" DataSourceID="ObjModificarUsuario" ForeColor="#333333" 
        GridLines="None" Height="50px" Width="125px">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="ID_USUARIO" HeaderText="ID_USUARIO" 
                SortExpression="ID_USUARIO" />
            <asp:BoundField DataField="ID_SUCURSAL" HeaderText="ID_SUCURSAL" 
                SortExpression="ID_SUCURSAL" />
            <asp:BoundField DataField="PASSWORD" HeaderText="PASSWORD" 
                SortExpression="PASSWORD" />
            <asp:BoundField DataField="PERFIL" HeaderText="PERFIL" 
                SortExpression="PERFIL" />
            <asp:BoundField DataField="NOMBRE_USUARIO" HeaderText="NOMBRE_USUARIO" 
                SortExpression="NOMBRE_USUARIO" />
            <asp:BoundField DataField="APELLIDO_USUARIO" HeaderText="APELLIDO_USUARIO" 
                SortExpression="APELLIDO_USUARIO" />
            <asp:BoundField DataField="USUARIO1" HeaderText="USUARIO1" 
                SortExpression="USUARIO1" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjModificarUsuario" runat="server" 
        SelectMethod="MostrarUsuarioByID" TypeName="servicioWeb.WCFTrans" 
        UpdateMethod="ModificarUsuario">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id_usuario" 
                Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="ID_USUARIO" Type="Int32" />
            <asp:Parameter Name="id_sucursal" Type="Int32" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="perfil" Type="String" />
            <asp:Parameter Name="NOMBRE_USUARIO" Type="String" />
            <asp:Parameter Name="APELLIDO_USUARIO" Type="String" />
            <asp:Parameter Name="usuario1" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

