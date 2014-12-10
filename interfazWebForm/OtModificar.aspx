<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="OtModificar.aspx.cs" Inherits="OtModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 11%;
    }
    .style8
    {
        width: 172px;
        text-align: justify;
    }
    .style9
    {
        width: 76%;
        text-align: justify;
    }
    .style10
    {
        width: 11%;
        text-align: justify;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Modificar OT</p>
<hr />
<br />
<table class="style1">
    <tr>
        <td class="style10">
            Seleccione OT
        </td>
        <td class="style8">
            <asp:DropDownList ID="ddOT" runat="server" DataSourceID="ObjAllOT" 
                DataTextField="Id_ot" DataValueField="Id_ot">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjAllOT" runat="server" SelectMethod="MotrarAllOt" 
                TypeName="servicioWeb.WCFTrans"></asp:ObjectDataSource>
        </td>
        <td class="style9">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" 
                onclick="btnModificar_Click" />
        </td>
    </tr>
    <tr>
        <td class="style7">
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

