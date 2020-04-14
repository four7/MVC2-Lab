using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MVC2_Lab1.Models;
using MVC2_Lab1.Service;
using MVC2_Lab1.ViewModels;

namespace MVC2_Lab1.Controllers
{
    public class GetIPController : Controller
    {
        private readonly IActionContextAccessor _accessor;
        private readonly IGetIpAddressService _ipAdressService;

        public GetIPController(IGetIpAddressService ipAddressService, IActionContextAccessor accessor)
        {
            _accessor = accessor;
            _ipAdressService = ipAddressService;
        }

        public IActionResult IPGet()
        {
            IPCheck check = new IPCheck();
            var checker = _ipAdressService.GetIPAddress();

            check.IPNr = checker.ToString();
            return View(check);
        }
    }
}