﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiMock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET http://localhost:5000/api/values/5
        [HttpGet("{id}")]
        
        public ActionResult<string> GetData(int id)
        {
            return "value";
        }

        // POST http://localhost:5000/api/values/second
        [HttpPost]
        [Route("second")]
        public ActionResult<string> SecondData([FromBody] string value)
        {
            return "value1";
        }

        // POST http://localhost:5000/api/values/third
        [HttpPost]
        [Route("third")]
        public ActionResult<string> ThirdData([FromBody] string value)
        {
            return "value2";
        }
    }
}
