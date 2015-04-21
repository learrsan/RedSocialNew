using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedSocial.Services;
using RedSocialWebApi.Models;

namespace RedSocial.Controllers
{
    public class AmigosController : Controller
    {
        BaseServicios<Amigos> servicio = new BaseServicios<Amigos>
               ("http://localhost:49322/api/Amigos"); 
        // GET: Amigos
        public ActionResult MisAmigos()
        {
            var us = Session["usuario"] as Usuario;
            if (us == null)
                return RedirectToAction("Index", "Autenticacion");
            var parametros = new Dictionary<String, Object>()
            {
                {"idUsuario", us.id}

            };
            var amigos = servicio.GetList(parametros);

            return View(amigos);

            
        }

        [HttpPost]
        public ActionResult AddAmigo(String txt)
        {
           
            


            return Json("Ok");
        }


    }
}







