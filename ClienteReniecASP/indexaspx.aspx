<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexaspx.aspx.cs" Inherits="ClienteReniecASP.indexaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Ingrese DNI: 
                <asp:TextBox runat="server" Id="txtDNI"></asp:TextBox>
                <asp:Button runat="server" ID="btnVer" Text="Consultar" OnClick="btnVer_Click" />
            </p>
            <p><asp:GridView runat="server" ID="gvDatosDni" CellPadding="4"></asp:GridView></p>
        </div>
    </form>
</body>
</html>
