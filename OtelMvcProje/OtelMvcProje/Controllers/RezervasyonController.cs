using OtelMvcProje.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelMvcProje.Controllers
{
    public class RezervasyonController : Controller
    {
        // GET: Rezervasyon
        DbOtelYeniEntities db = new DbOtelYeniEntities();

        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblOnRezervasyon p)
        {
            var misafirMail = (string)Session["Mail"];
            //ViewBag.a = misafirMail;//viewBag = bir sayfadan dıgerıne verı tasımak ıcın kullanılır. daha dogrusu controllerdan vıew e verı tasımak ıcın.
            //var misafirID = db.TblYeniKayit.Where(x => x.Mail == misafirMail).Select(x => x.ID).FirstOrDefault();

            //p.Durum = 16;
            //p.Misafir = misafirID;
            p.Mail = misafirMail;
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOnRezervasyon.Add(p);
            db.SaveChanges();
            return RedirectToAction("Rezervasyonlarim", "Misafir");
        }
    }
}