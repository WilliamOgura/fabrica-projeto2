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
        [HttpGet]
        public ActionResult Editar(int id)
        {
            //Buscar o objeto (aluno) no banco
            var aluno = _context.Aluno.Find(id);
            //Envia o objeto para a view de Edição
            return View(aluno);
        }
        [HttpPost]
        public ActionResult Editar(Aluno aluno)
        {
            _context.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Aluno Atualizado!";
            return RedirectToAction("Listar");
        }

        public ActionResult Excluir(int alunoId)
        {
            Aluno aluno = _context.Aluno.Find(alunoId);
            _context.Aluno.Remove(aluno);
            _context.SaveChanges();
            TempData["msg"] = "Aluno Expulso!";
            return RedirectToAction("Listar");
        }
    }
}