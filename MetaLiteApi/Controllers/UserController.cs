using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace MetaLiteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        


        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("Get User Success");
            return Ok(value: Helper.usersreadfile());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Users post)
        {
            Helper.Userwritefile(post);
            return Ok(value: Helper.usersreadfile());
        }
    }
}
