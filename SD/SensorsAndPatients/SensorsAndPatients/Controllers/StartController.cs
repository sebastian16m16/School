
using System.Web.Http;
using SensorsAndPatients.Resource;

namespace SensorsAndPatients.Controllers
{
    public class StartController : ApiController
    {
        public string Get()
        {
            ManageData manageData = new ManageData();

            manageData.handleData();
            return "start";
        }
    }
}
