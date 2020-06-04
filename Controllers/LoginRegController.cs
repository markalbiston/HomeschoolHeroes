using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HomeschoolHeroes.Models;

namespace HomeschoolHeroes.Controllers
{
    public class LoginRegController : Controller
    {
        private MyContext dbContext;
        public LoginRegController(MyContext context)
        {dbContext = context;}
        
        [HttpGet("/")]
        public IActionResult LandingPage(){
            return View();
        }
    }
}
