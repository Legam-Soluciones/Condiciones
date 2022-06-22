<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Promedio.aspx.cs" Inherits="Condiciones.Promedio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>Tenemos 3 Notas cual es el promedio, paso o se queda.</p>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Obj_Resultado" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
