using AppWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public HelloMessage GetMessage(string name)
        {
            HelloMessage message = new HelloMessage
            {
                MessageText = "Hello World!",
                UserName = "Welcome "+ name
            };

            return message;
        }
     
    }
}
