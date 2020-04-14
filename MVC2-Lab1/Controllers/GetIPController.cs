using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC2_Lab1.Controllers
{
    public class GetIPController : Controller
    {
        public IActionResult GetIP()
        {
            return View();
        }
    }
}