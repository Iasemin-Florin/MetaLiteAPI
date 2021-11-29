using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace MetaLiteApi.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Users> Get()
        {
            List<string> data = Helper.readfile();
            return (IEnumerable<Users>)data;
        }
    }
}
