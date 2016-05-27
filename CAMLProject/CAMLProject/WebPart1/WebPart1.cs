using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace CAMLProject.WebPart1
{
    [ToolboxItemAttribute(false)]
    public class WebPart1 : WebPart
    {
        protected override void CreateChildControls()
        {
            using (SPSite site = new SPSite("http://intranet.devlab.com"))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    SPList list = web.Lists["ArtistList"];
                    SPQuery query = new SPQuery();
                    query.Query = "<where><Eq><FieldRef Name = 'Genre />'"+
                        "<Value Type='Text'>Rock</Value></Eq></Where>";
                    SPListItemCollection collItems = list.GetItems(query);
                    ListBox displayList = new ListBox();
                    foreach (SPListItem item in collItems)
                    {
                        displayList.Items.Add(item.Title);
                    }
                    this.Controls.Add(displayList);
                }
            }

        }
    }
}
