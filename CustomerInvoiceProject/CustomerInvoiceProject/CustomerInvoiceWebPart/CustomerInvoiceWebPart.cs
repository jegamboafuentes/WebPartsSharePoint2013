using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace CustomerInvoiceProject.CustomerInvoiceWebPart
{
    [ToolboxItemAttribute(false)]
    public class CustomerInvoiceWebPart : WebPart
    {
        private DropDownList customerList = new DropDownList();
        private SPListItemCollection purchaseList;
        private SPListItemCollection customerName;

        private DropDownList purchaseDropDownList = new DropDownList();

        private bool invoiceReady = false;

        protected override void OnInit(EventArgs e)
        {
            SPWeb web = SPContext.Current.Web;
            SPList list = web.Lists["Customers"];
            SPListItemCollection listItems = list.Items;

            foreach (SPListItem item in listItems)
            {
                customerList.Items.Add(item["CustomerId"].ToString());
            }
        }

        protected override void CreateChildControls()
        {
            Label idLabel = new Label();
            idLabel.Text = "Select ID you want to generate Invoce for";
            Button sumbit = new Button();
            sumbit.Text = "Sumbit";
            sumbit.Click += new EventHandler(sumbit_Click);
            LiteralControl br = new LiteralControl("<br />");

            this.Controls.Add(idLabel);
            this.Controls.Add(customerList);
            this.Controls.Add(br);
            this.Controls.Add(sumbit);
        }

        void sumbit_Click(object sender, EventArgs e)
        {
            SPWeb web = SPContext.Current.Web;
            SPList list = web.Lists["Purchases"];
            SPQuery query = new SPQuery();
            String custID = customerList.SelectedItem.Text.ToString();

            query.Query = "<Where><Eq><FieldRef Name='CustomerId' /><Value Type='Text'>" +
                custID + "</Value></Eq></Where>";
            purchaseList = list.GetItems(query);

            SPList customerInfo = web.Lists["Customers"];
            SPQuery custQuery = new SPQuery();

            custQuery.Query = "<Where><Eq><FieldRef Name='CustomerId' /><Value Type='Text'>" +
                custID + "</Value></Eq></Where>";

            customerName = customerInfo.GetItems(custQuery);
            invoiceReady = true;
        }

        protected override void Render(HtmlTextWriter writer)
        {
            EnsureChildControls();
            RenderChildren(writer);

            if (invoiceReady)
            {
                double totalPrice = 0;
                writer.Write("<br><br><h2>Customer Info</h2><Table>");
                foreach (SPListItem cust in customerName)
                {
                    writer.Write("<tr><td>Customer ID: "+cust["CustomerId"].ToString()+"</td></tr>");
                    writer.Write("<tr><td>"+ cust["FirstName"].ToString()+" "+cust["LastName"].ToString()+ "</td></tr>");
                    writer.Write("<tr><td>" + cust["State"].ToString() + "</td></tr>");
                }
                writer.Write("</Table><br/>");

                writer.Write("<br><br><h2>Customer Pursaches</h2><Table>");
                foreach (SPListItem cust in purchaseList)
                {
                    writer.Write("<tr><td>Customer ID: " + cust["CustomerId"].ToString() + "</td></tr>");
                    writer.Write("<tr><td>Item Description:" + cust["ItemDescription"].ToString() + "</td></tr>");
                    writer.Write("<tr><td>Qty: " + cust["Qty"].ToString() + "</td></tr>");
                    writer.Write("<tr><td>Unit Price: " + cust["UnitPrice"].ToString() + "</td></tr>");
                    writer.Write("<tr><td>Total Price: " + cust["TotalPrice"].ToString() + "</td></tr>");
                }
                writer.Write("</Table><br/>");
            }
        }

    }
}
