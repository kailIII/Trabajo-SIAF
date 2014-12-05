<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="BodegaModificar.aspx.cs" Inherits="BodegaModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Modificar Bodega</p>
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            DataSourceID="ObjectModificarBodega" Height="50px" Width="125px" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
            <EditRowStyle BackColor="#7C6F57" />
            <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="COD_BODEGA" HeaderText="COD_BODEGA" 
                    SortExpression="COD_BODEGA" />
                <asp:BoundField DataField="ID_USUARIO" HeaderText="ID_USUARIO" 
                    SortExpression="ID_USUARIO" />
                <asp:CommandField ShowEditButton="True" />
            </Fields>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectModificarBodega" runat="server" 
            SelectMethod="MostrarBodegaByID" TypeName="servicioWeb.WCFTrans" 
            UpdateMethod="ModificarBodegabyID">
            <SelectParameters>
                <asp:QueryStringParameter Name="COD_BODEGA" QueryStringField="id_bodega" 
                    Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="COD_BODEGA" Type="String" />
                <asp:Parameter Name="ID_USUARIO" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>

