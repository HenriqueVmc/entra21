using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //
            ViewBag.Nome = "Stolfinho";
            ViewBag.Idade = 16;

            return View();
        }

        public ActionResult calculadora()
        {
            return View();
        }

        public ActionResult calcular(int num1, int num2)
        {
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;
            
            int soma = num1 + num2;
            ViewBag.Soma = soma;
            
            return View();
        }
    }
}