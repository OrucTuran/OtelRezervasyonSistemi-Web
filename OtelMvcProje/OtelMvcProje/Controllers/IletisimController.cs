﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entitiy;

namespace OtelMvcProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        public ActionResult Index()
        {
            var bilgiler = db.Tbliletisim.ToList();
            return View(bilgiler);
        }

        [HttpGet]
        public PartialViewResult MesajGonder()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MesajGonder(TblMesaj p)
        {
            db.TblMesaj.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
}