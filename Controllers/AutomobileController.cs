using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPVT.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;

namespace SPVT.Controllers
{
    
    

        public class AutomobileController : Controller
        {

            // GET: /Automobile/

            public IActionResult Index()
            {
                return View();
            } 

            
        }
    
}