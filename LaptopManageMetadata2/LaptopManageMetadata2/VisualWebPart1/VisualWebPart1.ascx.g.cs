﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaptopManageMetadata2.VisualWebPart1 {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    
    
    public partial class VisualWebPart1 {
        
        protected global::System.Web.UI.WebControls.Label lblTitle;
        
        protected global::System.Web.UI.WebControls.DropDownList DDBrand;
        
        protected global::System.Web.UI.WebControls.DropDownList DDModel;
        
        protected global::System.Web.UI.WebControls.Button btnSubmit;
        
        public static implicit operator global::System.Web.UI.TemplateControl(VisualWebPart1 target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblTitle() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblTitle = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblTitle";
            @__ctrl.Text = "Manage Metadata - Laptops";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlDDBrand() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.DDBrand = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "DDBrand";
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(27D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(120D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.AutoPostBack = true;
            @__ctrl.SelectedIndexChanged -= new System.EventHandler(this.DDBrand_SelectedIndexChanged);
            @__ctrl.SelectedIndexChanged += new System.EventHandler(this.DDBrand_SelectedIndexChanged);
            @__ctrl.Load -= new System.EventHandler(this.DDBrand_Load);
            @__ctrl.Load += new System.EventHandler(this.DDBrand_Load);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlDDModel() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.DDModel = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "DDModel";
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(27D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(120D, global::System.Web.UI.WebControls.UnitType.Pixel);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnSubmit() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.btnSubmit = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "btnSubmit";
            @__ctrl.Text = "Add to List";
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(120D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Click -= new System.EventHandler(this.btnSubmit_Click);
            @__ctrl.Click += new System.EventHandler(this.btnSubmit_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::LaptopManageMetadata2.VisualWebPart1.VisualWebPart1 @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<p>\r\n    "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControllblTitle();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n&nbsp;</p>\r\n<p>\r\n    "));
            global::System.Web.UI.WebControls.DropDownList @__ctrl2;
            @__ctrl2 = this.@__BuildControlDDBrand();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</p>\r\n<p>\r\n    "));
            global::System.Web.UI.WebControls.DropDownList @__ctrl3;
            @__ctrl3 = this.@__BuildControlDDModel();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</p>\r\n<p>\r\n    "));
            global::System.Web.UI.WebControls.Button @__ctrl4;
            @__ctrl4 = this.@__BuildControlbtnSubmit();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</p>\r\n<p>\r\n    &nbsp;</p>\r\n\r\n"));
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
