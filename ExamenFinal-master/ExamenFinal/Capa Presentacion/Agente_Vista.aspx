<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Agente_Vista.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Agente_Vista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/CATALOGOS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Gestión de Agentes</h1>

        <div>
            <label for="nombre">Nombre:</label>
            <asp:TextBox runat="server" type="text" id="nombre" name="nombre"></asp:TextBox>
            <label for="email">Email:</label>
            <asp:TextBox runat="server" type="email" id="email" name="email"></asp:TextBox>
            <label for="telefono">Teléfono:</label>
            <asp:TextBox runat="server" type="tel" id="telefono" name="telefono"></asp:TextBox>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        </div>

        <div>
            <label for="idBorrar">ID del Agente:</label>
            <asp:TextBox runat="server" type="number" id="idBorrar" name="idBorrar"></asp:TextBox>
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        </div>

        <div>
            <label for="idModificar">ID del Agente:</label>
            <asp:TextBox runat="server" type="number" id="idModificar" name="idModificar"></asp:TextBox>
            <label for="nombreModificar">Nuevo Nombre:</label>
            <asp:TextBox runat="server" type="text" id="nombreModificar" name="nombreModificar"></asp:TextBox><br>
            <label for="emailModificar">Nuevo Email:</label>
            <asp:TextBox runat="server" type="email" id="emailModificar" name="emailModificar"></asp:TextBox><br>
            <label for="telefonoModificar">Nuevo Teléfono:</label>
            <asp:TextBox runat="server" type="tel" id="telefonoModificar" name="telefonoModificar"></asp:TextBox><br>
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        </div>   

        <div>
            <h1>Agentes</h1>  
            <asp:GridView ID="listaAgentes" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>
