<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login_Vista.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Login_Vista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/CATALOGOS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestión de Usuarios</h1>
    <div>
        <label for="usuario">Usuario:</label>
        <asp:TextBox runat="server" type="text" id="usuario" name="usuario"></asp:TextBox>
        <label for="pass">Password:</label>
        <asp:TextBox runat="server" type="text" id="pass" name="pass"></asp:TextBox>  
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </div>
</asp:Content>
