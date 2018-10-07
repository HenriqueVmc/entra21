using Ex1AspMVC.Models;
using Ex1AspMVC.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1AspMVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        [HttpGet]
        public ActionResult Index()
        {
            List<Aluno> alunos = new AlunoRepositorio().obterTodos();
            ViewBag.Alunos = alunos;
            ViewBag.TituloPagina = "Alunos";
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Alunos - Cadastro";
            ViewBag.Aluno = new Aluno();
            return View();
        }

        [HttpPost]
        public ActionResult Store(Aluno aluno)
        {
            if (ModelState.IsValid)
            {                
                int cod = new AlunoRepositorio().cadastrar(aluno);
                return RedirectToAction("Editar", new { id = cod });
            }

            ViewBag.aluno = aluno;

            return View("Cadastro");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aluno aluno = new AlunoRepositorio().obterById(id);
            ViewBag.Aluno = aluno;

            ViewBag.TituloPagina = "Recrutadoras - Editar";
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new AlunoRepositorio().excluir(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Aluno aluno)
        {
            bool alterado = new AlunoRepositorio().alterar(aluno);
            return RedirectToAction("Index");
        }
    }
}