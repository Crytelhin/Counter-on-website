using Microsoft.AspNetCore.Mvc;
using System;
using IncrementerApp1.Domain;

namespace IncrementerApp1.Controllers
{
    [ApiController]
    [Route("incrementer")]
    public class IncrementerController : Controller
    {
        
        [HttpGet]
        public ActionResult<IncrementerResponse> Increment()
        {
            int currentValue = Request.Cookies["CurrentValue"] != null
                ? Convert.ToInt32(Request.Cookies["CurrentValue"]) + 1 : 0;
            Response.Cookies.Append("CurrentValue", $"{currentValue}");
            
            return Ok(new IncrementerResponse(currentValue));
        }
        
    }
}
