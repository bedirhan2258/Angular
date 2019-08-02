using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularBlok.API.Controllers
{
    public class denemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}