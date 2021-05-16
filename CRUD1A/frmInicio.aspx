<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="CRUD1A.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="width: 932px">
    <form id="form1" runat="server">
        <div style="height: 386px">
            <br />
            <asp:Label ID="Label1" runat="server" Text="PASAR DATOS A SQL SERVER "></asp:Label>
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
            <asp:Button ID="btnBuscarNombre" runat="server" OnClick="btnBuscarNombre_Click" Text="Buscar por Nombre" Width="179px" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="Yellow" OnClick="Button1_Click" Text="Pasar a MYSQL" Width="323px" />
        </div>
    </form>
</body>
</html>
