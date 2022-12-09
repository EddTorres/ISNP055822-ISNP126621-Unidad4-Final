<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Usuario.aspx.vb" Inherits="Pro1_Semana4_CRUD_Visual_Basic_MySQL.Usuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="text-align: center; font-size: xx-large">
        <strong>INICIAR SESION DE USUARIO:</strong></p>
    <p style="font-size: xx-large; text-align: center">
        nombre de usuario:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="196px"></asp:TextBox>
    </p>
    <p style="font-size: xx-large; text-align: center">
        contraseña:
        <asp:TextBox ID="TextBox2" runat="server" Width="181px"></asp:TextBox>
    </p>
    <p style="font-size: xx-large; text-align: center">
        <asp:Button ID="BtnInciarSesion" runat="server" Font-Bold="True" Text="INICIAR SESION" />
&nbsp;
        <asp:Button ID="BtnCrearUsuario" runat="server" Font-Bold="True" Text="CREAR USUARIO" />
    </p>
</asp:Content>
