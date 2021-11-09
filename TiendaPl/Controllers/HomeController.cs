using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaPl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(Bll.PublicoBll.ObtenerProductos());
        }
        public ActionResult Login()
        {
            return View(new Usuario());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Email,Password")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario verificado = Bll.UsuariosBll.Verificar(usuario);

                if (verificado != null)
                {
                    Session["usuario"] = verificado;
                    ViewBag.Mensaje = "";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Mensaje = "Email o contraseña incorrectos";
            return View(usuario);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
        public ActionResult DetalleProducto(long id)
        {
            return View(Bll.PublicoBll.BuscarProductoPorId(id));
        }
    }
}