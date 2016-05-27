<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalculatorJS.ascx.cs" Inherits="CalculatorJS.CalculatorJS.CalculatorJS" %>
<link href="../_layouts/15/CalculatorJS/view.css" rel="stylesheet" />
<div id="container">
        <div id="container2">
            <div id="calculator" class="calc">
                <!-- Screen and clear key -->
                <div class="top">
                    <span class="clear">C</span>
                    <div class="screen"></div>
                </div>

                <div class="keys">
                    <!-- operators and other keys -->
                    <span>7</span>
                    <span>8</span>
                    <span>9</span>
                    <span class="operator">Del</span>
                    <span>4</span>
                    <span>5</span>
                    <span>6</span>
                    <span class="operator">+</span>
                    <span>1</span>
                    <span>2</span>
                    <span>3</span>
                    <span class="operator">-</span>
                    <span>0</span>
                    <span>.</span>
                    <span class="eval">=</span>
                    <span class="operator">/</span>

                    <span>Sin</span>
                    <span>Cos</span>
                    <span>Tan</span>
                    <span class="operator">x</span>
                </div>
            </div>
        </div>
    </div>
    <!-- PrefixFree -->
    <script src="http://thecodeplayer.com/uploads/js/prefixfree-1.0.7.js" type="text/javascript"></script>
    <script src="../_layouts/15/CalculatorJS/logic.js" type="text/javascript"></script>