using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RickFreelanceWebApp.Controllers
{
    public class LightsOutController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Games/LightsOut/Index.cshtml");
        }
    }
}