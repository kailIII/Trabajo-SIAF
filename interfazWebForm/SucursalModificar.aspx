<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="SucursalModificar.aspx.cs" Inherits="SucursalModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Modificar Sucursal</p>
    <hr />
<br />
<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
    CellPadding="4" DataSourceID="ObjModificarSucursal" ForeColor="#333333" 
    GridLines="None" Height="50px" Width="125px">
    <AlternatingRowStyle BackColor="White" />
    <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
    <EditRowStyle BackColor="#7C6F57" />
    <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
    <Fields>
        <asp:BoundField DataField="ID_SUCURSAL" HeaderText="ID_SUCURSAL" 
            SortExpression="ID_SUCURSAL" />
        <asp:BoundField DataField="DIRECCION_SUCURSAL" HeaderText="DIRECCION_SUCURSAL" 
            SortExpression="DIRECCION_SUCURSAL" />
        <asp:BoundField DataField="TELEFONO_SUCURSAL" HeaderText="TELEFONO_SUCURSAL" 
            SortExpression="TELEFONO_SUCURSAL" />
        <asp:CommandField ShowEditButton="True" />
    </Fields>
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
</asp:DetailsView>
<asp:ObjectDataSource ID="ObjModificarSucursal" runat="server" 
    SelectMethod="MostrarSucursalByID" TypeName="servicioWeb.WCFTrans" 
    UpdateMethod="ModificarSucursalbyID">
    <SelectParameters>
        <asp:QueryStringParameter Name="ID_SUCURSAL" QueryStringField="id_sucursal" 
            Type="Int32" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SUCURSAL" Type="Int32" />
        <asp:Parameter Name="DIRECCION_SUCURSAL" Type="String" />
        <asp:Parameter Name="TELEFONO_SUCURSAL" Type="Int32" />
    </UpdateParameters>
</asp:ObjectDataSource>
</asp:Content>

