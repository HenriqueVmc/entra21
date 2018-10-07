using ExemploMVC02.Models;
using ExemploMVC02.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        // GET: Recrutadora
        [HttpGet]
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepositorio().obterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            ViewBag.TituloPagina = "Recrutadoras";
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Recrutadoras - Cadastro";
            ViewBag.Recrutadora = new Recrutadora();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Recrutadora recrutadora = new RecrutadoraRepositorio().obterById(id);

            ViewBag.Recrutadora = recrutadora;
            ViewBag.TituloPagina = "Recrutadoras - Editar";
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new RecrutadoraRepositorio().excluir(id);
            return null;
        }

        [HttpPost]
        public ActionResult Store(Recrutadora recrutadora)
        {
            if (ModelState.IsValid)
            {
                recrutadora.Cpf = recrutadora.Cpf.Replace(".", "").Replace("-", "");
                int cod = new RecrutadoraRepositorio().cadastrar(recrutadora);
                return RedirectToAction("Editar", new { id = cod });            
            }

            ViewBag.recrutadora = recrutadora;

            return View("Cadastro");
        }

        [HttpPost]
        public ActionResult Update(Recrutadora recrutadora)
        {

            bool alterado = new RecrutadoraRepositorio().alterar(recrutadora);
            return null;
        }
    }
}