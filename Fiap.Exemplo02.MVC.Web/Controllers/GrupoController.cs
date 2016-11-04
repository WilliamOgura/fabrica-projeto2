using Fiap.Exemplo02.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Web.Controllers
{
    public class GrupoController : Controller
    {

        private GrupoContext _context = new Context();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Grupo grupo)
        {
            _context.Grupo.Add(grupo);
            _context.SaveChanges();
            TempData["msg"] = "Grupo cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}