using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPomiar.DAL;
using WebPomiar.Models;

namespace WebPomiar.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.msg = TempData["sendMsg"];
            ViewBag.order = TempData["sendOrder"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private ApplicationDbContext _db = new ApplicationDbContext();

        [HttpPost]
        public ActionResult Send(Message msg)
        {

            if (ModelState.IsValid)
            {
                _db.Messages.Add(msg);
                _db.SaveChanges();

                TempData["sendMsg"] = true;

                return RedirectToAction("Index");
            }

            return View("Index", msg);
        }

        [Route("zamow")]
        public ActionResult NewOrder(int package)
        {
            TempData["pakiet"] = package;

            return View();
        }

        [Route("zamow")]
        [HttpPost]
        public ActionResult NewOrder(Order or1)
        {



            or1.Package = (int)TempData["pakiet"];

            //Enum.GetName(typeof(Package), );

            if (ModelState.IsValid)
            {
                _db.Orders.Add(or1);
                _db.SaveChanges();

                TempData["sendOrder"] = true;

                return RedirectToAction("Index");
            }

            return View(or1);
        }


    }
}