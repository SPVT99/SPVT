using Microsoft.AspNetCore.Mvc;

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