using MVC2_Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2_Lab1.ViewModels
{
    public class IPCheckViewModel
    {
        public IPCheck checker { get; set; }
        public string IPNr { get; set; }
        public IPCheckViewModel()
        {
            checker = new IPCheck();
        }
    }
}
