using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HelloCore.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [HttpGet]
        [Route("")]
        public string Phone()
        {
            return "+32 489 50 49 12";
        }

        [HttpGet]
        [Route("address")]
        public string Address()
        {
            return "België";
        }
    }
}
