using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //alta
            dbEntities ctx = new dbEntities();
            Empleado em = new Empleado();
            em.apellido = "perez";
            em.nombre = "Juan";
            ctx.Empleado.Add(em);
            ctx.SaveChanges();
            
            //modificar
            int myid = 1;
            //busco el objeto
            Empleado em2 = ctx.Empleado.Find(myid);
            em2.nombre = "Beto";
            ctx.SaveChanges();
            /*
             * se puede consultar por su estado obj:
             * -unchanged
             * -added
             * -modified
             * -deleted
             * -detached
             */

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}