using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; 
using System.Threading.Tasks;
using MoxiWorks.Platform; 
namespace WebFormExample
{
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
}