using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private ILister lister;

        public HomeController(ILister lister)
        {
            this.lister = lister;
        }
        public IActionResult Index()
        {
            return View(lister.ShowList());
        }
    }
}
