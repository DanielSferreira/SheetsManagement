using Microsoft.AspNetCore.Mvc;

namespace ManageSheets.Controllers
{
    [ApiController]
    [Route("/bas")]
    public class BaseController : ControllerBase
    {

        public BaseController()
        {
        }

        public string Get()
        {
            return "";
        }
    }
}
