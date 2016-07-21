<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisualWebPart1.ascx.cs" Inherits="LaptopManageMetadata2.VisualWebPart1.VisualWebPart1" %>
<p>
    <asp:Label ID="lblTitle" runat="server" Text="Manage Metadata - Laptops"></asp:Label>
&nbsp;</p>
<p>
    <asp:DropDownList ID="DDBrand" runat="server" Height="27px" OnSelectedIndexChanged="DDBrand_SelectedIndexChanged" Width="120px" AutoPostBack="True" OnLoad="DDBrand_Load">
    </asp:DropDownList>
</p>
<p>
    <asp:DropDownList ID="DDModel" runat="server" Height="27px" Width="120px">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Add to List" Width="120px" />
</p>
<p>
    &nbsp;</p>

