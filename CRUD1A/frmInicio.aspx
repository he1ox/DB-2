<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="CRUD1A.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 193px">
            <br />
            <br />
            <asp:Button ID="ButtonCargaDatos" runat="server" OnClick="ButtonCargaDatos_Click" Text="Cargar Datos A DB" />
            <br />
            <br />
            <asp:TextBox ID="txtboxID" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarID" runat="server" Text="Buscar por ID" Width="120px" OnClick="btnBuscarID_Click1" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtBoxNombre" runat="server" Width="427px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" Width="119px" />
        </div>
    </form>
</body>
</html>
