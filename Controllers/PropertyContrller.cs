namespace mvcRakuten.Controllers
{

    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{pid}", Name = "GetTodo")]   
        public async Task<ActionResult<string>> GetProperties(string pid){
            
            string properties = "string.Empty"; 
            
            await Task.Run(()=>{
                properties = "hello";
            });

            return properties;
        }
    }
}