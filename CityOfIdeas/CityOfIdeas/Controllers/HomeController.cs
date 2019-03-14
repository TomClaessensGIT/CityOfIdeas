using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CID.BL;
using Microsoft.AspNetCore.Mvc;

namespace CityOfIdeas.Controllers
{
    public class HomeController : Controller
    {
        private IProjectManager mgr;

        public HomeController()
        {
            mgr = new ProjectManager();

        }
        public IActionResult Index()
        {
            ViewBag.projects = mgr.GetProjects();
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}