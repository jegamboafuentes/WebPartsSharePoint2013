﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculator.CalcuatorWebPart {
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
    
    
    public partial class CalcuatorWebPart {
        
        protected global::System.Web.UI.WebControls.Button C;
        
        protected global::System.Web.UI.WebControls.Label Display;
        
        protected global::System.Web.UI.WebControls.Button _7;
        
        protected global::System.Web.UI.WebControls.Button _8;
        
        protected global::System.Web.UI.WebControls.Button _9;
        
        protected global::System.Web.UI.WebControls.Button delete;
        
        protected global::System.Web.UI.WebControls.Button _4;
        
        protected global::System.Web.UI.WebControls.Button _5;
        
        protected global::System.Web.UI.WebControls.Button _6;
        
        protected global::System.Web.UI.WebControls.Button add;
        
        protected global::System.Web.UI.WebControls.Button _1;
        
        protected global::System.Web.UI.WebControls.Button _2;
        
        protected global::System.Web.UI.WebControls.Button _3;
        
        protected global::System.Web.UI.WebControls.Button sub;
        
        protected global::System.Web.UI.WebControls.Button _0;
        
        protected global::System.Web.UI.WebControls.Button _dot;
        
        protected global::System.Web.UI.WebControls.Button eval;
        
        protected global::System.Web.UI.WebControls.Button div;
        
        protected global::System.Web.UI.WebControls.Button sin;
        
        protected global::System.Web.UI.WebControls.Button cos;
        
        protected global::System.Web.UI.WebControls.Button tan;
        
        protected global::System.Web.UI.WebControls.Button plus;
        
        public static implicit operator global::System.Web.UI.TemplateControl(CalcuatorWebPart target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlC() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.C = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "C";
            @__ctrl.Text = "C";
            @__ctrl.Click -= new System.EventHandler(this.C_Click);
            @__ctrl.Click += new System.EventHandler(this.C_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControlDisplay() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.Display = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Display";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_7() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._7 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_7";
            @__ctrl.Text = "7";
            @__ctrl.Click -= new System.EventHandler(this._7_Click);
            @__ctrl.Click += new System.EventHandler(this._7_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_8() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._8 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_8";
            @__ctrl.Text = "8";
            @__ctrl.Click -= new System.EventHandler(this._8_Click);
            @__ctrl.Click += new System.EventHandler(this._8_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_9() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._9 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_9";
            @__ctrl.Text = "9";
            @__ctrl.Click -= new System.EventHandler(this._9_Click);
            @__ctrl.Click += new System.EventHandler(this._9_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControldelete() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.delete = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "operator";
            @__ctrl.ID = "delete";
            @__ctrl.Text = "<";
            @__ctrl.Click -= new System.EventHandler(this.delete_Click);
            @__ctrl.Click += new System.EventHandler(this.delete_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_4() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._4 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_4";
            @__ctrl.Text = "4";
            @__ctrl.Click -= new System.EventHandler(this._4_Click);
            @__ctrl.Click += new System.EventHandler(this._4_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_5() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._5 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_5";
            @__ctrl.Text = "5";
            @__ctrl.Click -= new System.EventHandler(this._5_Click);
            @__ctrl.Click += new System.EventHandler(this._5_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_6() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._6 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_6";
            @__ctrl.Text = "6";
            @__ctrl.Click -= new System.EventHandler(this._6_Click);
            @__ctrl.Click += new System.EventHandler(this._6_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControladd() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.add = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "operator";
            @__ctrl.ID = "add";
            @__ctrl.Text = "+";
            @__ctrl.Click -= new System.EventHandler(this.add_Click);
            @__ctrl.Click += new System.EventHandler(this.add_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_1() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._1 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_1";
            @__ctrl.Text = "1";
            @__ctrl.Click -= new System.EventHandler(this._1_Click);
            @__ctrl.Click += new System.EventHandler(this._1_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_2() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._2 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_2";
            @__ctrl.Text = "2";
            @__ctrl.Click -= new System.EventHandler(this._2_Click);
            @__ctrl.Click += new System.EventHandler(this._2_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_3() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._3 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_3";
            @__ctrl.Text = "3";
            @__ctrl.Click -= new System.EventHandler(this._3_Click);
            @__ctrl.Click += new System.EventHandler(this._3_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlsub() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.sub = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "operator";
            @__ctrl.ID = "sub";
            @__ctrl.Text = "-";
            @__ctrl.Click -= new System.EventHandler(this.sub_Click);
            @__ctrl.Click += new System.EventHandler(this.sub_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_0() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._0 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_0";
            @__ctrl.Text = "0";
            @__ctrl.Click -= new System.EventHandler(this._0_Click);
            @__ctrl.Click += new System.EventHandler(this._0_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControl_dot() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this._dot = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "_dot";
            @__ctrl.Text = ".";
            @__ctrl.Click -= new System.EventHandler(this._dot_Click);
            @__ctrl.Click += new System.EventHandler(this._dot_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControleval() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.eval = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "eval";
            @__ctrl.ID = "eval";
            @__ctrl.Text = "=";
            @__ctrl.Click -= new System.EventHandler(this.eval_Click);
            @__ctrl.Click += new System.EventHandler(this.eval_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControldiv() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.div = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "operator";
            @__ctrl.ID = "div";
            @__ctrl.Text = "/";
            @__ctrl.Click -= new System.EventHandler(this.div_Click);
            @__ctrl.Click += new System.EventHandler(this.div_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlsin() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.sin = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "sin";
            @__ctrl.Text = "Sin";
            @__ctrl.Click -= new System.EventHandler(this.sin_Click);
            @__ctrl.Click += new System.EventHandler(this.sin_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlcos() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.cos = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "cos";
            @__ctrl.Text = "Cos";
            @__ctrl.Click -= new System.EventHandler(this.cos_Click);
            @__ctrl.Click += new System.EventHandler(this.cos_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControltan() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.tan = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "tan";
            @__ctrl.Text = "Tan";
            @__ctrl.Click -= new System.EventHandler(this.tan_Click);
            @__ctrl.Click += new System.EventHandler(this.tan_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlplus() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.plus = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "operator";
            @__ctrl.ID = "plus";
            @__ctrl.Text = "x";
            @__ctrl.Click -= new System.EventHandler(this.plus_Click);
            @__ctrl.Click += new System.EventHandler(this.plus_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::Calculator.CalcuatorWebPart.CalcuatorWebPart @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<div>\r\n    <table>\r\n        <tr>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl1;
            @__ctrl1 = this.@__BuildControlC();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <th colspan=\"3\">"));
            global::System.Web.UI.WebControls.Label @__ctrl2;
            @__ctrl2 = this.@__BuildControlDisplay();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</th>\r\n        </tr>\r\n        <tr>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl3;
            @__ctrl3 = this.@__BuildControl_7();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl4;
            @__ctrl4 = this.@__BuildControl_8();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl5;
            @__ctrl5 = this.@__BuildControl_9();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl6;
            @__ctrl6 = this.@__BuildControldelete();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(" </td>\r\n        </tr>\r\n        <tr>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl7;
            @__ctrl7 = this.@__BuildControl_4();
            @__parser.AddParsedSubObject(@__ctrl7);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl8;
            @__ctrl8 = this.@__BuildControl_5();
            @__parser.AddParsedSubObject(@__ctrl8);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl9;
            @__ctrl9 = this.@__BuildControl_6();
            @__parser.AddParsedSubObject(@__ctrl9);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl10;
            @__ctrl10 = this.@__BuildControladd();
            @__parser.AddParsedSubObject(@__ctrl10);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl11;
            @__ctrl11 = this.@__BuildControl_1();
            @__parser.AddParsedSubObject(@__ctrl11);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl12;
            @__ctrl12 = this.@__BuildControl_2();
            @__parser.AddParsedSubObject(@__ctrl12);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl13;
            @__ctrl13 = this.@__BuildControl_3();
            @__parser.AddParsedSubObject(@__ctrl13);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl14;
            @__ctrl14 = this.@__BuildControlsub();
            @__parser.AddParsedSubObject(@__ctrl14);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl15;
            @__ctrl15 = this.@__BuildControl_0();
            @__parser.AddParsedSubObject(@__ctrl15);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl16;
            @__ctrl16 = this.@__BuildControl_dot();
            @__parser.AddParsedSubObject(@__ctrl16);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl17;
            @__ctrl17 = this.@__BuildControleval();
            @__parser.AddParsedSubObject(@__ctrl17);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl18;
            @__ctrl18 = this.@__BuildControldiv();
            @__parser.AddParsedSubObject(@__ctrl18);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl19;
            @__ctrl19 = this.@__BuildControlsin();
            @__parser.AddParsedSubObject(@__ctrl19);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl20;
            @__ctrl20 = this.@__BuildControlcos();
            @__parser.AddParsedSubObject(@__ctrl20);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl21;
            @__ctrl21 = this.@__BuildControltan();
            @__parser.AddParsedSubObject(@__ctrl21);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n            <td>"));
            global::System.Web.UI.WebControls.Button @__ctrl22;
            @__ctrl22 = this.@__BuildControlplus();
            @__parser.AddParsedSubObject(@__ctrl22);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</td>\r\n        </tr>\r\n    </table>\r\n</div>"));
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
