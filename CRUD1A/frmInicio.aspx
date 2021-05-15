<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="CRUD1A.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 113px">
            <br />
            <br />
            <asp:Button ID="ButtonCargaDatos" runat="server" OnClick="ButtonCargaDatos_Click" Text="Cargar Datos A DB" />
        </div>
    </form>
</body>
</html>
