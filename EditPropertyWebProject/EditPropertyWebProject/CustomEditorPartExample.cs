using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace EditPropertyWebProject.EditPropertiesWebPart
{
    class CustomEditorPartExample : EditorPart
    {
        TextBox TxtUserGreeting = new TextBox();
        RadioButtonList FontSizeList = new RadioButtonList();

        protected override void CreateChildControls()
        {
            Label TextUserInput = new Label();
            Label RadioSelect = new Label();
            LiteralControl br = new LiteralControl("<br />");

            TextUserInput.Text = "Enter text to be displayed";
            RadioSelect.Text = "Select font size";
            FontSizeList.Items.Add("14");
            FontSizeList.Items.Add("18");
            FontSizeList.Items.Add("22");
            FontSizeList.Items.Add("26");

            this.Controls.Add(TextUserInput);
            this.Controls.Add(TxtUserGreeting);
            this.Controls.Add(br);
            this.Controls.Add(RadioSelect);
            this.Controls.Add(FontSizeList);
        }

        public override void SyncChanges()
        {
            EnsureChildControls();
            EditPropertiesWebPart webpart = this.WebPartToEdit as EditPropertiesWebPart;
            TxtUserGreeting.Text = webpart.UserGreeting;

            ListItem FontItem = FontSizeList.Items.FindByText(webpart.TextFontSize.ToString());
            FontItem.Selected = true;
        }

        public override bool ApplyChanges()
        {
            EnsureChildControls();
            EditPropertiesWebPart webpart = this.WebPartToEdit as EditPropertiesWebPart;
            webpart.UserGreeting = TxtUserGreeting.Text;
            webpart.TextFontSize = Convert.ToInt32(FontSizeList.Text);
            return true;
        }
    }
}
