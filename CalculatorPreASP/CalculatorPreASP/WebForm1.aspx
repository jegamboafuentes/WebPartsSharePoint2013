<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorPreASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    <table>
        <tr>
            <td><asp:Button ID="Clear" runat="server" Text="C" OnClick="Clear_Click" /></td>
            <th colspan="3"><asp:Label ID="Display" runat="server" Text="0"></asp:Label></th>
        </tr>
        <tr>
            <td><asp:Button ID="_7" runat="server" Text="7" OnClick="_7_Click" /></td>
            <td><asp:Button ID="_8" runat="server" Text="8" OnClick="_8_Click" /></td>
            <td><asp:Button ID="_9" runat="server" Text="9" /></td>
            <td><asp:Button CssClass="operator" ID="delete" runat="server" Text="<" /> </td>
        </tr>
        <tr>
            <td><asp:Button ID="_4" runat="server" Text="4" /></td>
            <td><asp:Button ID="_5" runat="server" Text="5" /></td>
            <td><asp:Button ID="_6" runat="server" Text="6" /></td>
            <td><asp:Button CssClass="operator" ID="add" runat="server" Text="+" OnClick="add_Click" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="_1" runat="server" Text="1" /></td>
            <td><asp:Button ID="_2" runat="server" Text="2" /></td>
            <td><asp:Button ID="_3" runat="server" Text="3" /></td>
            <td><asp:Button CssClass="operator" ID="sub" runat="server" Text="-" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="_0" runat="server" Text="0" /></td>
            <td><asp:Button ID="_dot" runat="server" Text="." /></td>
            <td><asp:Button CssClass="eval" ID="eval" runat="server" Text="=" /></td>
            <td><asp:Button CssClass="operator" ID="div" runat="server" Text="/" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="sin" runat="server" Text="Sin" /></td>
            <td><asp:Button ID="cos" runat="server" Text="Cos" /></td>
            <td><asp:Button ID="tan" runat="server" Text="Tan" /></td>
            <td><asp:Button CssClass="operator" ID="plus" runat="server" Text="x" /></td>
        </tr>
    </table>

</div>

</body>
</html>
