using Additional.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Additional.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalcService _calcService;
        public HomeController(CalcService calcService)
        {
            _calcService = calcService;
        }
        public IActionResult Index()
        {
            return View(new Calc());
        }
        [HttpPost]
        public IActionResult Index(Calc calc, string calculate)
        {
                 
            
            switch (calculate)
            {
                case "+":
                    calc.Result = _calcService.Add(calc.Number1, calc.Number2);
                    break;
                case "-":
                    calc.Result = _calcService.Sub(calc.Number1, calc.Number2);
                    break;
                case "*":
                    calc.Result = _calcService.Mul(calc.Number1, calc.Number2);
                    break;
                case "/":
                    calc.Result = _calcService.Div(calc.Number1, calc.Number2);
                    break;
                case "clear":
                    calc.Result = _calcService.Clear(calc.Number1, calc.Number2);
                    break;

            }
            return View(calc);

        }


        
        
    }
}
