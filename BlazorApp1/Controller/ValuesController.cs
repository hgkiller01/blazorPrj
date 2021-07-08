using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            return new List<string>() { "a", "b" };
        }
        [HttpPost]
        public PostData Post(PostData test)
        {
            
            return test;
        }
        public class PostData
        {
            public List<string> Test { get; set; }
        }
    }
}
