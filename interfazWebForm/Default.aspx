<%@ Page Language="C#" Debug="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 198px;
        }
        .style2
        {
            width: 60px;
        }
        .style3
        {
            width: 128px;
        }
        .style4
        {
            width: 100%;
        }
        .style5
        {
            width: 98px;
        }
        .style6
        {
            width: 100px;
        }
        .style7
        {
            color: #66667E;
        }
        .style8
        {
            width: 60px;
            color: #66667E;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
        <table align="center" class="style4">
            <tr>
                <td class="style5">
                    <h1>
                        &nbsp;</h1>
                </td>
                <td class="style6">
                    <h1 class="style7">
                    SIAF</h1>
                </td>
                <td class="style7">
                    Sistema Informacion Administrativa Ferreteria</td>
            </tr>
        </table>
    
        <table align="center" class="style1">
            <tr>
                <td class="style8">
                    Usuario</td>
                <td class="style3">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    Password</td>
                <td class="style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnIngresar" runat="server" onclick="btnIngresar_Click" 
                        Text="Ingresar" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Label ID="lblMensaje" runat="server" style="color: #FF0000"></asp:Label>
                </td>
            </tr>
        </table>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
