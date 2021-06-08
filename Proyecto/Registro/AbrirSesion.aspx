<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbrirSesion.aspx.cs" Inherits="Proyecto.Registro.AbrirSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <h1 class="btn-success focus">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Incia Sesion</h1>
    <p>
        &nbsp;</p>
    <p>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1" style="margin-left: 254px" TitleText="Bienvenido" Width="637px">
        </asp:Login>
</p>
    <p>
        &nbsp;</p>
    <p>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="70px" style="margin-left: 456px" Width="132px">
        <asp:ListItem>Medico</asp:ListItem>
        <asp:ListItem>Secretaria</asp:ListItem>
    </asp:RadioButtonList>
</p>
<p>
</p>
</asp:Content>
