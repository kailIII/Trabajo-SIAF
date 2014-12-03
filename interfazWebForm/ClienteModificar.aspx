<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ClienteModificar.aspx.cs" Inherits="ClienteModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Mantenedor Cliente</p>
    <hr />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        CellPadding="4" DataSourceID="ObjModificarCliente" ForeColor="#333333" 
        GridLines="None" Height="50px" Width="125px">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="ID_CLIENTE" HeaderText="ID_CLIENTE" 
                SortExpression="ID_CLIENTE" />
            <asp:BoundField DataField="NOMBRE_CLIENTE" HeaderText="NOMBRE_CLIENTE" 
                SortExpression="NOMBRE_CLIENTE" />
            <asp:BoundField DataField="RUT" HeaderText="RUT" SortExpression="RUT" />
            <asp:BoundField DataField="TELEFONO_CLIENTE" HeaderText="TELEFONO_CLIENTE" 
                SortExpression="TELEFONO_CLIENTE" />
            <asp:BoundField DataField="MAIL" HeaderText="MAIL" SortExpression="MAIL" />
            <asp:BoundField DataField="DIRECCION_CLIENTE" HeaderText="DIRECCION_CLIENTE" 
                SortExpression="DIRECCION_CLIENTE" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjModificarCliente" runat="server" 
        SelectMethod="MostrarClienteByID" TypeName="servicioWeb.WCFTrans" 
        UpdateMethod="ModificarClientebyID">
        <SelectParameters>
            <asp:QueryStringParameter Name="id_cliente" QueryStringField="id_cliente" 
                Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="ID_CLIENTE" Type="Int32" />
            <asp:Parameter Name="NOMBRE_CLIENTE" Type="String" />
            <asp:Parameter Name="RUT" Type="String" />
            <asp:Parameter Name="TELEFONO_CLIENTE" Type="Int32" />
            <asp:Parameter Name="MAIL" Type="String" />
            <asp:Parameter Name="DIRECCION_CLIENTE" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>

