using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RightSolutions4u.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }
        public IActionResult Portfolio()
        {
            return View("Portfolio");
        }
    }
}
