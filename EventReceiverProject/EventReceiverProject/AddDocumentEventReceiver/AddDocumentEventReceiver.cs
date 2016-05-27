using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace EventReceiverProject.AddDocumentEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class AddDocumentEventReceiver : SPItemEventReceiver
    {
        /// <summary>
        /// An item was updated.
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            base.ItemUpdated(properties);
            this.EventFiringEnabled = false;

            if (properties.ListItem.Fields.ContainsField("Public"))
            {
                if (Convert.ToBoolean(properties.ListItem["Public"].ToString()))
                {
                    properties.ListItem.File.CopyTo(properties.WebUrl + "/MyDocuments/"+properties.ListItem.File.Name, true);
                }
            }
            this.EventFiringEnabled = true;

        }


    }
}