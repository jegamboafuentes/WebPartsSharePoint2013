using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace SimpleTimerJobProject
{
    class SimbleJobDefinition : SPJobDefinition
    {
        public const string JobName = "SimpleJobDefinition";
        public SimbleJobDefinition()
            : base()
        {
        }

        public SimbleJobDefinition(SPWebApplication webApp) : base(JobName, webApp, null, SPJobLockType.Job)
        {

        }

        public override void Execute(Guid targetInstanceId)
        {
            SPWebApplication webApp = this.Parent as SPWebApplication;
            SPList taskList = webApp.Sites[0].RootWeb.Lists["Task"];
            SPListItem newTask = taskList.Items.Add();
            newTask["Title"] = DateTime.Now.ToString();
            newTask.Update();
        }

    }
}
