using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPomiar.DAL;

namespace WebPomiar.Controllers
{

    [RoutePrefix("backroom")]
    [Authorize]
    public class BackroomController : Controller
    {
        // GET: Backroom

        private ApplicationDbContext _db = new ApplicationDbContext();


        public ActionResult Index()
        {
            var lista = _db.Messages.ToList();

            return View(lista);
        }

        [Route("msg")]
        public ActionResult GetMsg()
        {
            var lista = _db.Messages.ToList();

            return View(lista);
        }


        [Route("order")]
        public ActionResult GetOrders()
        {
            var orders = _db.Orders.ToList();

            return View(orders);
        }
    }
}