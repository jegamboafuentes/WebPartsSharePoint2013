Notes: 
1- For Add CSS and JS, resources etc.. You Should:
 i Right click on project -> Add -> SharePoint "Layouts" mapped folder
ii  Inside of the folder, create or copy your resources

2- Sessions on Web Parts
 i Change Session["YourVariableSession"] for Page.Session["YourVariableSession"]
ii Open SharePoint 2013 Managment Shell as Administrator and type the following command:
    Enable-SPSessionStateService –DefaultProvision
