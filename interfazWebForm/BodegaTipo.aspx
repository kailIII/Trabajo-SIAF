<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="BodegaTipo.aspx.cs" Inherits="BodegaTipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {}
    .style7
    {
        width: 344px;
    }
    .style8
    {
        width: 91%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Informe por Tipo</p>
<hr />
<br />
<table class="style1">
    <tr>
        <td class="style7">
            Seleccione Tipo</td>
        <td class="style8">
            <asp:DropDownList ID="ddTipo" runat="server" AutoPostBack="True" 
                DataSourceID="ObjMostrarAllTipo" DataTextField="Nombre_tipo" 
                DataValueField="Id_tipo">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjMostrarAllTipo" runat="server" 
                SelectMethod="MotrarAllTipo" TypeName="servicioWeb.WCFTrans">
            </asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td class="style6" colspan="2">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjMostrarTipoById" 
                ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID_TIPO" HeaderText="ID_TIPO" 
                        SortExpression="ID_TIPO" />
                    <asp:BoundField DataField="NOMBRE_TIPO" HeaderText="NOMBRE_TIPO" 
                        SortExpression="NOMBRE_TIPO" />
                    <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="NOMBRE_PRODUCTO" 
                        SortExpression="NOMBRE_PRODUCTO" />
                    <asp:BoundField DataField="COD_BODEGA" HeaderText="COD_BODEGA" 
                        SortExpression="COD_BODEGA" />
                    <asp:BoundField DataField="CANTIDAD_ACTUAL" HeaderText="CANTIDAD_ACTUAL" 
                        SortExpression="CANTIDAD_ACTUAL" />
                    <asp:BoundField DataField="VALOR" HeaderText="VALOR" SortExpression="VALOR" />
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
            <asp:ObjectDataSource ID="ObjMostrarTipoById" runat="server" 
                SelectMethod="spInformeTipo" TypeName="servicioWeb.WCFTrans">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddTipo" Name="ID_TIPO" 
                        PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
    </tr>
</table>
</asp:Content>

