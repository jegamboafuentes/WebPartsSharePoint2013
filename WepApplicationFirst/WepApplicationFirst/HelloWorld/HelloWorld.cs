using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace WepApplicationFirst.HelloWorld
{
    [ToolboxItemAttribute(false)]
    public class HelloWorld : WebPart
    {
        protected override void CreateChildControls()
        {
            Label label = new Label();
            label.Text = "What's up Enrique";
            this.Controls.Add(label);
        }
    }
}
