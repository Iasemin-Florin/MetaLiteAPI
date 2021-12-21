using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaLiteApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            return Ok(Helper.loginCorrect(Username, Password));
        }
        
    }
}
