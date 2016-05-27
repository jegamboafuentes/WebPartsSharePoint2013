<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorPreASP2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><asp:Button ID="C" runat="server" Text="C" OnClick="C_Click" /></td>
            <th colspan="3"><asp:Label ID="Display" runat="server"></asp:Label></th>
        </tr>
        <tr>
            <td><asp:Button ID="_7" runat="server" Text="7" OnClick="_7_Click" /></td>
            <td><asp:Button ID="_8" runat="server" Text="8" OnClick="_8_Click" /></td>
            <td><asp:Button ID="_9" runat="server" Text="9" OnClick="_9_Click" /></td>
            <td><asp:Button CssClass="operator" ID="delete" runat="server" Text="<" OnClick="delete_Click" /> </td>
        </tr>
        <tr>
            <td><asp:Button ID="_4" runat="server" Text="4" OnClick="_4_Click" /></td>
            <td><asp:Button ID="_5" runat="server" Text="5" OnClick="_5_Click" /></td>
            <td><asp:Button ID="_6" runat="server" Text="6" OnClick="_6_Click" /></td>
            <td><asp:Button CssClass="operator" ID="add" runat="server" Text="+" OnClick="add_Click" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="_1" runat="server" Text="1" OnClick="_1_Click" /></td>
            <td><asp:Button ID="_2" runat="server" Text="2" OnClick="_2_Click" /></td>
            <td><asp:Button ID="_3" runat="server" Text="3" OnClick="_3_Click" /></td>
            <td><asp:Button CssClass="operator" ID="sub" runat="server" Text="-" OnClick="sub_Click" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="_0" runat="server" Text="0" OnClick="_0_Click" /></td>
            <td><asp:Button ID="_dot" runat="server" Text="." OnClick="_dot_Click" /></td>
            <td><asp:Button CssClass="eval" ID="eval" runat="server" Text="=" OnClick="eval_Click" /></td>
            <td><asp:Button CssClass="operator" ID="div" runat="server" Text="/" OnClick="div_Click"/></td>
        </tr>
        <tr>
            <td><asp:Button ID="sin" runat="server" Text="Sin" OnClick="sin_Click" /></td>
            <td><asp:Button ID="cos" runat="server" Text="Cos" OnClick="cos_Click" /></td>
            <td><asp:Button ID="tan" runat="server" Text="Tan" OnClick="tan_Click" /></td>
            <td><asp:Button CssClass="operator" ID="plus" runat="server" Text="x" OnClick="plus_Click" /></td>
        </tr>
    </table>

</div>


    </form>
</body>
</html>
