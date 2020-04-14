using MVC2_Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2_Lab1.Service
{
    public interface IGetIpAddressService
    {
        IPCheck Get();
        string GetIPAddress();
    }
}
