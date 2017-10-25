using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPVT.Models;
using Microsoft.EntityFrameworkCore;

namespace SPVT.Controllers
{
    public class HelloWorld
    {

        public class HelloWorldController : Controller
        {

            // GET: /Automobile/

            public IActionResult Index()
            {
                return View();
            }

            // 
            // GET: /Automobile/Welcome/ 

           public IActionResult Welcome(string name, int numTimes = 1)
            {
                ViewData["Message"] = "Hello " + name;
                ViewData["NumTimes"] = numTimes;
                return View();
            }

        }
    }
}