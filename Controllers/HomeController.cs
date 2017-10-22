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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to SPVT, this application will provide you with the ability to record vehicle violations at the Amazon account, this information will then be transmitted to you, to send to your account manager, and L.P, if you have any questions feel free to contact your supervisor, or your account manager for more information.";

            

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your Contact Information.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
