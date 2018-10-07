using Ex2AspMVC.Models;
using Ex2AspMVC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex2AspMVC.Controllers
{
    public class ConsertoController : Controller
    {
        // GET: Conserto
        public ActionResult Index()
        {
            List<Conserto> consertos = new ConsertoRepositorio().obterTodos();
            ViewBag.Conserto = consertos;
            ViewBag.TituloPagina = "Consertos";
            return View();
        }
        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Consertos - Cadastro";
            ViewBag.Conserto = new Conserto();
            return View();
        }

        [HttpPost]
        public ActionResult Store(Conserto conserto)
        {
            if (ModelState.IsValid)
            {
                int cod = new ConsertoRepositorio().cadastrar(conserto);
                return RedirectToAction("Editar", new { id = cod });
            }

            ViewBag.Conserto = conserto;

            return View("Cadastro");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Conserto conserto = new ConsertoRepositorio().obterById(id);
            ViewBag.Conserto = conserto;

            ViewBag.TituloPagina = "Consertos - Editar";
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new ConsertoRepositorio().excluir(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Conserto conserto)
        {
            bool alterado = new ConsertoRepositorio().alterar(conserto);
            return RedirectToAction("Index");
        }
    }
}