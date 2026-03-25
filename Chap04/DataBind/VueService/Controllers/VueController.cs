using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class VueController : ControllerBase
    {
        public VueController() 
        { 
        }
        //POST: api/Vue
        [HttpPost]
        public string PostData(UserData data) 
        {
            return "成功!";
        }
    }
}
