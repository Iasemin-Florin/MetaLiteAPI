using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MetaLiteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MypostController : Controller
    {


        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("Get Post Success");
            return Ok(Helper.Postsreadfile(filepath));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Posts post)
        {
            Helper.Postwritefile(post, filepath);
            return Ok(value: Helper.Postsreadfile(filepath));
        }
    }
}
