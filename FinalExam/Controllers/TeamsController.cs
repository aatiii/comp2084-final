using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FinalExam.Models;

namespace FinalExam.Controllers
{
    public class TeamsController : Controller
    {
        private finalExam db = new finalExam();
        // GET: Teams
        public ActionResult Index()
        {
            var teams = db.Teams.ToList();

            var teamsZa = from t in teams
                          orderby t.Points descending
                          select t;

            return View(teamsZa);
        }
    }
}