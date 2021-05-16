<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formMYSQL.aspx.cs" Inherits="CRUD1A.formMYSQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 287px">
            <center style="height: 18px">
                <asp:Label ID="Label1" runat="server" Text="MYSQL - DATABASE"></asp:Label>

            </center>
                <asp:Button ID="btnCargarDatos" runat="server" Text="Cargar CSV a BD" OnClick="btnCargarDatos_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEliminarDatos" runat="server" OnClick="btnEliminarDatos_Click" Text="Eliminar Datos" Visible="False" Width="176px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Realizar Busqueda por ID:"></asp:Label>
&nbsp;<br />
            <asp:TextBox ID="txtBoxID" runat="server" Width="151px"></asp:TextBox>
            <asp:Button ID="btnBuscarID" runat="server" OnClick="btnBuscarID_Click" Text="Buscar ID" Width="113px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Realizar Busqueda por Nombre:"></asp:Label>
            <br />
            <asp:TextBox ID="txtBoxNombre" runat="server" Width="380px"></asp:TextBox>
            <asp:Button ID="btnBuscarNombre" runat="server" OnClick="btnBuscarNombre_Click" Text="Buscar Nombre" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnProbarBD" runat="server" OnClick="btnProbarBD_Click" Text="Probar Conexion" Width="155px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
