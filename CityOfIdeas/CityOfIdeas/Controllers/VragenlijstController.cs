using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CID.BL;
using Microsoft.AspNetCore.Mvc;

namespace CityOfIdeas.Controllers
{
    public class VragenlijstController : Controller
    {
        private IProjectManager mgr;

        public VragenlijstController()
        {
            mgr = new ProjectManager();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BevestigVragenlijst()
        {
            ViewBag.projects = mgr.GetProjects().Take(3);
            return View();
        }
    }
}