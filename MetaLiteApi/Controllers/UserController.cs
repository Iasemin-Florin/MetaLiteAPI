﻿using Microsoft.AspNetCore.Mvc;
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
        string FilePath = Environment.CurrentDirectory + "/FileDB/DBusers.txt";

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(value: Helper.usersreadfile(FilePath));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Users post)
        {
            Helper.Userwritefile(post, FilePath);
            return Ok(value: Helper.usersreadfile(FilePath));
        }
    }
}
