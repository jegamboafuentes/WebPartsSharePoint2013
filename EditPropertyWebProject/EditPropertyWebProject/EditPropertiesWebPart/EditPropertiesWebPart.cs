using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace EditPropertyWebProject.EditPropertiesWebPart
{
    [ToolboxItemAttribute(false)]
    public class EditPropertiesWebPart : WebPart
    {
        [Personalizable(PersonalizationScope.User), WebBrowsable(false),
            WebDisplayName("User Greeting"), Category("Web Browsable Properties")]
        public string UserGreeting { get; set; }

        [Personalizable(PersonalizationScope.User), WebBrowsable(true),
        WebDisplayName("Text Color"), Category("Web Browsable Properties")]
        public TextColorEnum TextColor { get; set; }

        [Personalizable(PersonalizationScope.User), WebBrowsable(false)]
        public int TextFontSize { get;set; }

        public enum TextColorEnum
        {
            purple,
            red,
            blue,
            black
        }
        protected override void OnInit(EventArgs e)
        {
            TextFontSize = 14;
        }

        protected override void CreateChildControls()
        {
            Label displayGreeting = new Label();
            displayGreeting.Text = UserGreeting;
            displayGreeting.Style.Add("color", TextColor.ToString());
            displayGreeting.Font.Size = TextFontSize;
            this.Controls.Add(displayGreeting);
        }

        public override EditorPartCollection CreateEditorParts()
        {
            EditorPart editor = new CustomEditorPartExample();
            editor.ID = this.ID + "_editor";
            EditorPart[] parts = { editor };
            return new EditorPartCollection(base.CreateEditorParts(), parts);

        }
    }
}
