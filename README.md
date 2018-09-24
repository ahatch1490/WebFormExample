# WebFormExample
Example of using Moxiworks.PlatForm in a WebForm 

Need to include the following in the web.config application section:
```
<appSettings>
    <add key="Secret" value="sercret here" /> <! --- Add your MoxiWorks secret --> 
    <add key="Identifier" value="identifier here" /> <!-- Add your MoxiWorks identifier -->
    <add key ="CompanyId" value="company id here"/> <!-- Add the ID of your company with in the api we use this to get all the agents --> 
</appSettings>
```
The service call to get the agents is in Agents.aspx.cs
```
public partial class Agents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            var companyId = System.Configuration.ConfigurationManager.AppSettings["CompanyId"]; 
            var client = new MoxiWorksClient();
            var service = new AgentService(client);
            var source = System.Threading.Tasks.Task.Run(() => service.GetAgentsAsync(companyId, null, DateTime.Now.AddDays(-100))).Result; 
            gvAgent.DataSource = source.Item.Agents; 
            gvAgent.DataBind();
    }
}
```
