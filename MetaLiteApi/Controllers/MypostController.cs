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
        string filepath = "/FileDB/DBposts.txt";

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Helper.postsreadfile(filepath));
        }   

        [HttpPost]
        public IActionResult Post([FromBody] Posts post)
        {
            Helper.postwritefile(post, filepath);
            return Ok(value: Helper.postsreadfile(filepath));
        }
    }
}
