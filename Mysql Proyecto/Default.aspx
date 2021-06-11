﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mysql_Proyecto.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>CodAutor : <asp:TextBox runat="server" ID="txtCodAutor" /></p>
            <p>ApellidoS : <asp:TextBox runat="server" ID="txtApellidos" /></p>
            <p>Nombres : <asp:TextBox runat="server" ID="txtNombres" /></p>
            <p>Nacionalidad : <asp:TextBox runat="server" ID="txtNacionalidad" /></p>
            <p>Buscar: <asp:TextBox runat="server" ID="txtbusqueda"/>
                 <asp:Button Text="Buscar" runat="server" ID="btnBuscar"   />
            </p>
            <p>
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" />
            </p>
            <asp:GridView runat="server" ID="gvAutor">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
