<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="TipoModificar.aspx.cs" Inherits="TipoModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;</p>
<p>
    &nbsp;Moditicar Tipo</p>
<p>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        CellPadding="4" DataSourceID="ObjModificarTipo" ForeColor="#333333" 
        GridLines="None" Height="50px" Width="125px">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="ID_TIPO" HeaderText="ID_TIPO" 
                SortExpression="Codigo" />
            <asp:BoundField DataField="NOMBRE_TIPO" HeaderText="NOMBRE TIPO" 
                SortExpression="NOMBRE_TIPO" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjModificarTipo" runat="server" 
        SelectMethod="MostrarTipoByID" TypeName="servicioWeb.WCFTrans" 
        UpdateMethod="ModificarTipo">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID_TIPO" QueryStringField="id_tipo" 
                Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="ID_TIPO" Type="Int32" />
            <asp:Parameter Name="NOMBRE_TIPO" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>

