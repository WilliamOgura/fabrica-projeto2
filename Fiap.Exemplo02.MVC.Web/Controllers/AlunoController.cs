using Fiap.Exemplo02.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Web.Controllers
{
    public class AlunoController : Controller
    {

        private AlunoContext _context = new AlunoContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        
       

        public ActionResult Cadastrar(Aluno aluno)
        {
            _context.Aluno.Add(aluno);
            _context.SaveChanges();
            TempData["msg"] = "Aluno cadastrado!";
            return RedirectToAction("Cadastrar");
        }
        public ActionResult Listar()
        {
            var lista = _context.Aluno.ToList();
            return View(lista);
        }
    }
}