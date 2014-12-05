<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ProductosOT.aspx.cs" Inherits="ProductosOT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Agregar Productos a la OT</p>
    <hr />
    <asp:Label ID="lbl_idsucursal" runat="server" Visible="False"></asp:Label>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataSourceID="ObjMostrarOt" Height="50px" Width="279px" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="ID_OT" HeaderText="Numero OT" 
                SortExpression="ID_OT" />
            <asp:BoundField DataField="ID_SUCURSAL" HeaderText="Codigo Sucursal" 
                SortExpression="ID_SUCURSAL" />
            <asp:BoundField DataField="ID_CLIENTE" HeaderText="Codigo Cliente" 
                SortExpression="ID_CLIENTE" />
            <asp:BoundField DataField="NETO_OT" HeaderText="NETO" 
                SortExpression="NETO_OT" />
            <asp:BoundField DataField="FECHA_OT" HeaderText="FECHA" 
                SortExpression="FECHA_OT" />
            <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                SortExpression="ESTADO" />
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjMostrarOt" runat="server" 
        SelectMethod="MostrarOTaByID" TypeName="servicioWeb.WCFTrans">
        <SelectParameters>
            <asp:ControlParameter ControlID="lbl_idsucursal" Name="ID_OT" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    <br />
</asp:Content>

