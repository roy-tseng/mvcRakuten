namespace mvcRakuten.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;


    public class AirportController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }

}