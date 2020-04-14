using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MVC2_Lab1.Controllers;
using MVC2_Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2_Lab1.Service
{
    public class GetIpAddressService : IGetIpAddressService
    {
        private readonly IActionContextAccessor _accessor;
        

        public GetIpAddressService(IActionContextAccessor accessor)
        {
            _accessor = accessor;
        }

        //public IPCheck Get()
        //{
        //    IPCheck test = new IPCheck();
        //    _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();

        //    return test;
        //}

        public string GetIPAddress()
        {
            return _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
        }
    }
}
