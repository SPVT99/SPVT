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



    public class AutomobileController : Controller
        {

        // GET: /Automobile/
        [HttpGet]
        public IActionResult Index() => View();

        //GET: Automobiles/Vehicles 
        [HttpGet]
         public IActionResult getVehicles() => View();

         //DELETE: Automobiles/Delete  //Vehicles Testing page//
         [HttpGet]
         public IActionResult deleteVehicles() => View();
           

            
        }
    
}