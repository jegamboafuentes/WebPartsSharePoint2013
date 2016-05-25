<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverterWebPart.ascx.cs" Inherits="CurrencyConverter.CurrencyConverterWebPart.CurrencyConverterWebPart" %>
<h3 style="font-size:14px">Currency Converter</h3>
<br />
<div class="currencyconverter">
    <br />
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox ID="UserText" runat="server" Width="40px"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="150px"> </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="intoLabel" runat="server" Text="into" Font-Size="12px" style="color:Black;"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="150px"> </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell> </asp:TableCell>
            <asp:TableCell>
                <div style="text-align:right">
                    <asp:Button ID="Submit" runat="server" onclick="Submit_Click" style="height: 26px" Text="Submit" /> </div>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    <asp:Label ID="results" runat="server" Font-Size="12px" style="color:Black;"></asp:Label>
</div>
<style type="text/css">
    .currencyconverter {
        width: 220px;
        height: 150px;
        text-align: center;
        border: 1px solid #90B3FD;
    }
</style>

<%--<h3 style="font-size:14px">Currency Converter</h3>
<br />
<div class="currencyConverter"></div>
<br />
<asp:Table ID="Table1" runat="server">
    <asp:TableRow>
        <asp:TableCell>
            <asp:TextBox ID="UserTextBox" runat="server" Width="40px"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:DropDownList ID="CountryDropDownList" runat="server" Width="150px"></asp:DropDownList>
        </asp:TableCell>
        <asp:TableCell>
            <asp:Label ID="lblOne" runat="server" Text="into"></asp:Label>
        </asp:TableCell>
        
    </asp:TableRow>

</asp:Table>--%>