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
        string FilePath = "D:/FileDB/DBusers.txt";
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(value: Helper.usersreadfile(FilePath));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Users post)
        {
            //Users newuser = new Users(username, email, password);
            
            Helper.Userwritefile(post, FilePath);
            return Ok(value: Helper.usersreadfile(FilePath));
        }
    }
}
