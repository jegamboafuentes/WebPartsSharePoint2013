using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Taxonomy;

namespace LaptopManageMetadata2.VisualWebPart1
{
    [ToolboxItemAttribute(false)]
    public partial class VisualWebPart1 : WebPart
    {

        public VisualWebPart1()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //clean();
        }

        protected void DDBrand_Load(object sender, EventArgs e)
        {
            var spSite = new SPSite(@"http://intranet.devlab.com/");
            var taxSession = new TaxonomySession(spSite);
            if (DDBrand.Items.Count == 0)
            {
                var termStore = taxSession.TermStores["Managed Metadata Service"];
                var termStoreGroup = termStore.Groups["Laptops"];
                var termSet = termStoreGroup.TermSets["Dell"];
                var deps = termSet.Terms;

                foreach (var dep in termStoreGroup.TermSets)
                {
                    DDBrand.Items.Add(dep.Name);
                }
            }
        }

        private void clean()
        {
            DDModel.Items.Clear();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var web = SPContext.Current.Site.RootWeb;
            var list = web.Lists.TryGetList("Laptops");
            var managedMetaDataField = list.Fields["brand"] as TaxonomyField;
            var managedMetaDataField2 = list.Fields["Model"] as TaxonomyField;
            var termsetId = managedMetaDataField.TermSetId;
            var termstoreId = managedMetaDataField.SspId;
            var termsetId2 = managedMetaDataField2.TermSetId;
            var termstoreId2 = managedMetaDataField2.SspId;
            var taxonomySession = new TaxonomySession(web.Site);
            var termstore = taxonomySession.TermStores[termstoreId];
            var termstore2 = taxonomySession.TermStores[termstoreId2];
            var termset = termstore.GetTermSet(termsetId);
            var termset2 = termstore2.GetTermSet(termsetId2);
            var termname = DDBrand.SelectedValue;
            var termname2 = DDModel.Text;
            String brand = DDBrand.SelectedValue;
            String model = DDModel.Text;
            var terms = termset.GetTerms(termname, false);
            var terms2 = termset2.GetTerms(termname2, false);
            Term term;
            Term term2;
            if (terms.Count == 0)
            {
                term = termset.CreateTerm(termname, termstore.Languages[0]);
                termstore.CommitAll();
            }
            else
            {
                term = terms[0];
            }
            if (terms2.Count == 0)
            {
                term2 = termset2.CreateTerm(termname2, termstore2.Languages[0]);
                termstore2.CommitAll();
            }
            else
            {
                term2 = terms2[0];
            }
            SPListItemCollection items = list.Items;
            SPListItem item = items.Add();
            item[SPBuiltInFieldId.Title] = "Computer";
            managedMetaDataField.SetFieldValue(item, term);
            managedMetaDataField2.SetFieldValue(item, term2);
            item.Update();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Computer Added into List')", true);
        }

        protected void DDBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            String brand = DDBrand.Text;
            var spSite = new SPSite(@"http://intranet.devlab.com/");
            var taxSession = new TaxonomySession(spSite);
            var termStore = taxSession.TermStores["Managed Metadata Service"];
            var termStoreGroup = termStore.Groups["Laptops"];
            var termSet = termStoreGroup.TermSets[brand];
            var deps = termSet.Terms;
            DDModel.Items.Clear();
            foreach (var dep in deps)
            {
                DDModel.Items.Add(dep.Name);
            }
        }

    }
}
