<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="BodegaInforme.aspx.cs" Inherits="BodegaInforme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 146px;
        }
        .style7
        {
            width: 89%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Informe por Bodega</p>
<hr />
    <br />
    <table class="style1">
        <tr>
            <td class="style6">
                Seleccione Bodega</td>
            <td class="style7">
                <asp:DropDownList ID="ddBodega" runat="server" AutoPostBack="True" 
                    DataSourceID="ObjMostrarAllBodega" DataTextField="Cod_bodega" 
                    DataValueField="Cod_bodega">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjMostrarAllBodega" runat="server" 
                    SelectMethod="MotrarAllBodega" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CellPadding="4" 
                    DataSourceID="ObjMostrarInformeBodega" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="COD_BODEGA" HeaderText="COD_BODEGA" 
                            SortExpression="COD_BODEGA" />
                        <asp:BoundField DataField="PRODUCTO_COD" HeaderText="PRODUCTO_COD" 
                            SortExpression="PRODUCTO_COD" />
                        <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="NOMBRE_PRODUCTO" 
                            SortExpression="NOMBRE_PRODUCTO" />
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
                <asp:ObjectDataSource ID="ObjMostrarInformeBodega" runat="server" 
                    SelectMethod="spInformeBodega" TypeName="servicioWeb.WCFTrans">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddBodega" Name="COD_BODEGA" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

