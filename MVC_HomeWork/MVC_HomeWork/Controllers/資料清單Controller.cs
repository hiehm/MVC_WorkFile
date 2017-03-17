using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_HomeWork.Models;

namespace MVC_HomeWork.Controllers
{
    public class 資料清單Controller :BaseController
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: 資料清單
        public ActionResult Index()
        {
            return View(db.View.ToList());
        }

        // GET: 資料清單/Details/5

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
