<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ot.aspx.cs" Inherits="ot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 51px;
        }
        .style7
        {
            width: 263px;
        }
        .style8
        {
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />Crear OT</p>
    <hr />
    <table class="style7">
        <tr>
            <td class="style6">
                Cliente</td>
            <td class="style8">
                <asp:DropDownList ID="ddCliente" runat="server" DataSourceID="ObjMuestraClientes" 
                    DataTextField="Rut" DataValueField="Id_cliente">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjMuestraClientes" runat="server" 
                    SelectMethod="MotrarAllCliente" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Sucursal</td>
            <td class="style8">
                <asp:DropDownList ID="ddSucursal" runat="server" DataSourceID="ObjMostrarSucursal" 
                    DataTextField="Direccion_sucursal" DataValueField="Id_sucursal">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjMostrarSucursal" runat="server" 
                    SelectMethod="MotrarAllSucursal" TypeName="servicioWeb.WCFTrans">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td style="margin-left: 40px" class="style8">
                <asp:Button ID="btnSiguiente" runat="server" 
                    Text="Siguiente" onclick="btnSiguiente_Click" />
            </td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>

