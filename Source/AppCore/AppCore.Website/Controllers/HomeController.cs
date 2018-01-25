using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppCore.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace AppCore.Website.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFlexUserService _flexUserService;
        public HomeController(IFlexUserService flexUserService)
        {
            _flexUserService = flexUserService;
        }
        public IActionResult Index()
        {
            var teest = _flexUserService.GetAll();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
