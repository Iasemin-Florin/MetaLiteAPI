using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MetaLiteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MypostController : Controller
    {
        string filepath = "D:/FileDB/DBposts.txt";

        /*public IActionResult Index()
        {
            return Ok(Helper.postsreadfile(filepath));
        }*/

        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(Helper.postsreadfile(filepath));
            return Ok(new Posts[] { new Posts("hej", "test", "img") });
        }   

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Posts post)
        {
            Helper.postwritefile(post, filepath);
            return Ok(value: Helper.postsreadfile(filepath));
        }
    }
}
