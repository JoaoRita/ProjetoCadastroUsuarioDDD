using System.Web.Mvc;
using AutoMapper;
using System.Collections.Generic;
using ProjetoCadastroUsuarioDDD.Domain.Entities;
using ProjetoCadastroUsuarioDDD.MVC.ViewModels;
using ProjetoCadastroUsuarioDDD.Application.Interface;
using Microsoft.AspNetCore.Cors;
using System.Linq;

namespace ProjetoCadastroUsuarioDDD.MVC.Controllers
{

    
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public UsuariosController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
       }

        // GET: Usuario
        [HttpGet]
        
        public JsonResult Index()
        {

           
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.GetAll());
                        
            return Json(usuarioViewModel, JsonRequestBehavior.AllowGet);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        

        public JsonResult Create(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var mensagem = "Usuario cadastrado com sucesso";
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Add(usuarioDomain);
                return Json(new { success = true, usuario.Nome, usuario.UsuarioId,usuario.CPF, mensagem });
            }
            return Json(new
            {
                success = false,
                errors = ModelState.Keys.SelectMany(i => ModelState[i].Errors).Select(m => m.ErrorMessage).ToArray()
            });
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Update(usuarioDomain);

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            _usuarioApp.Remove(usuario);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public JsonResult Login(string login, string senha)
        {
            if (login == "a" && senha == "a")
            {

                return Json(new { success = true });
            }
            return Json(new
            {
                success = false,
            });
        }
    }
}
