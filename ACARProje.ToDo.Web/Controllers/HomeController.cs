using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACARProje.ToDo.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ACARProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        IGorevService _gorevService;
        public HomeController(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
