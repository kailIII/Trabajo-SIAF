<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ProductosOT.aspx.cs" Inherits="ProductosOT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 56px;
        }
        .style7
        {
            width: 91px;
        }
        .style8
        {
            width: 55px;
        }
        .style9
        {
            width: 128px;
        }
        .style10
        {
            width: 408px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Agregar Productos a la OT</p>
    <hr />
    <asp:Label ID="lbl_idot" runat="server" Visible="False"></asp:Label>
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
            <asp:BoundField DataField="ID_SUCURSAL" HeaderText="Sucursal" 
                SortExpression="ID_SUCURSAL" />
            <asp:BoundField DataField="ID_CLIENTE" HeaderText="Cliente" 
                SortExpression="ID_CLIENTE" />
            <asp:BoundField DataField="NETO_OT" HeaderText="Neto" 
                SortExpression="NETO_OT" />
            <asp:BoundField DataField="FECHA_OT" HeaderText="Fecha Creacion" 
                SortExpression="FECHA_OT" />
            <asp:BoundField DataField="ESTADO" HeaderText="Estado" 
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
            <asp:ControlParameter ControlID="lbl_idot" Name="ID_OT" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <hr />
    <table class="style10">
        <tr>
            <td class="style6">
                Producto</td>
            <td class="style7">
                <asp:DropDownList ID="dd_productoCod" runat="server" AutoPostBack="True" 
                    DataSourceID="ObjProductosAll" DataTextField="Nombre_producto" 
                    DataValueField="Producto_cod">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjProductosAll" runat="server" 
                    SelectMethod="MotrarAllProducto" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
            <td class="style8">
                Cantidad</td>
            <td class="style9">
                <asp:TextBox ID="txtCantidad" runat="server" Width="83px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" 
                    onclick="btnAgregar_Click" />
            </td>
        </tr>
    </table>
    <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjMostrarProductosByID_OT" CellPadding="4" 
    ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="id_producto_ot" 
                DataNavigateUrlFormatString="ProductosOTEliminar.aspx?id_producto_ot={0}" 
                DataTextField="id_producto_ot" HeaderText="Eliminar" Text="Eliminar" />
            <asp:BoundField DataField="id_ot" HeaderText="Numero OT" 
                SortExpression="id_ot" />
            <asp:BoundField DataField="nombre_producto" HeaderText="Nombre Producto" 
                SortExpression="nombre_producto" />
            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" 
                SortExpression="cantidad" />
            <asp:BoundField DataField="valor_total" HeaderText="Valor Total" 
                SortExpression="valor_total" />
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
    <asp:ObjectDataSource ID="ObjMostrarProductosByID_OT" runat="server" 
        DeleteMethod="BorrarProductoOTBYIDPRODUCTOOT" 
        SelectMethod="MostrarProductosOtByIDOT" TypeName="servicioWeb.WCFTrans">
        <DeleteParameters>
            <asp:Parameter Name="ID_PRODUCTO_OT" Type="Int32" />
        </DeleteParameters>
        <SelectParameters>
            <asp:QueryStringParameter Name="ID_OT" QueryStringField="id_ot" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    </asp:Content>

