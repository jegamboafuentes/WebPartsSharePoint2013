using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace AsyncEventReceiverProject.AsyncAddEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class AsyncAddEventReceiver : SPItemEventReceiver
    {

        //public override void ItemAttachmentAdded(SPItemEventProperties properties)
        //{
            
        //}

        /// <summary>
        /// An item was updated
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            properties.ListItem["CreatedName"] = properties.ListItem["Created By"];
            properties.ListItem.Update();
            base.ItemUpdated(properties);
        }


    }
}