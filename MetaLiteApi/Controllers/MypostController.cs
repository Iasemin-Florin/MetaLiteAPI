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

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Posts[] arry = null;
            Task jak = new Task
                (
                () =>
                {
                  arry=  Helper.postsreadfile(filepath);

                }
                );

            jak.Start();
            Task.WaitAll(jak);

           return Ok(arry);
        }   

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Posts post)
        {
            Helper.postwritefile(post, filepath);
            return Ok(value: Helper.postsreadfile(filepath));
        }
    }
}
