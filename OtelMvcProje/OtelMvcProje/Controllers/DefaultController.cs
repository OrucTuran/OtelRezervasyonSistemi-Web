using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entitiy;

namespace OtelMvcProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //@ sembolu html tarafında c# kodları yazmamıza olanak sağlar --> razor syntax

        DbOtelYeniEntities db = new DbOtelYeniEntities();
        public ActionResult Hakkimda()
        {
            var veriler = db.TblHakkimda.ToList();
            return View(veriler);
        }
        public PartialViewResult Ekibimiz()
        {
            var ekipListesi = db.TblEkibimiz.ToList();
            return PartialView(ekipListesi);
        }

        public PartialViewResult PartialFooter()
        {
            var doluOda = db.TblOda.Where(x => x.Durum != 1).Count();
            ViewBag.d = doluOda;
            var boşOda = db.TblOda.Where(x => x.Durum == 1).Count();
            ViewBag.b = boşOda;
            return PartialView();
        }
        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
        public PartialViewResult Istatistik()
        {
            return PartialView();
        }
        public PartialViewResult Referanslar()
        {
            return PartialView();
        }
    }
}