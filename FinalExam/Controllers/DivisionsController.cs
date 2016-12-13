using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using FinalExam.Models;

namespace FinalExam.Controllers
{
    public class DivisionsController : Controller
    {
        // connect to the db
        private finalExam db = new finalExam();
        // GET: Divisions
        public ActionResult Index()
        {                       
            {
                return View(db.Divisions.ToList().OrderBy(d => d.Name));
            }
            
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Division div = db.Divisions.Find(id);
            if (div == null)
            {
                return HttpNotFound();
            }
            return View(div);
        }
    }
}