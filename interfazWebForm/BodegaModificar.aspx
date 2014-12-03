<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="BodegaModificar.aspx.cs" Inherits="BodegaModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Modificar Bodega</p>
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            DataSourceID="ObjectModificarBodega" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="COD_BODEGA" HeaderText="COD_BODEGA" 
                    SortExpression="COD_BODEGA" />
                <asp:BoundField DataField="ID_USUARIO" HeaderText="ID_USUARIO" 
                    SortExpression="ID_USUARIO" />
                <asp:CommandField ShowEditButton="True" />
            </Fields>
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

