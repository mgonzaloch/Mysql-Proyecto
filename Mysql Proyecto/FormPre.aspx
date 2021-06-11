<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPre.aspx.cs" Inherits="Mysql_Proyecto.capaNegocio.FormPre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>CodAutor: <asp:TextBox runat="server" ID="txtcodAutor" /> </p>
            <p>CodLibro: <asp:TextBox runat="server" ID="txtcodLibro" /> </p>
            <p>FechaPrestamo:<asp:TextBox runat="server" ID="txtFecha" />
                <asp:Calendar runat="server" ID="Calendar" OnSelectionChanged="Calendar_SelectionChanged" /> </p>
            <p>Buscar: <asp:TextBox runat="server" ID="txtbusqueda"/>
                 <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
            </p>
            <p>
                 <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click"  />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminarr"  OnClick="btnEliminar_Click"/>
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click"/>
                <asp:Button Text="Listar" runat="server" ID="btnListar" OnClick="btnListar_Click" />
               
            </p>
            <asp:GridView runat="server" ID="gvPrestamo" ></asp:GridView>
        </div>
    </form>
</body>
</html>
