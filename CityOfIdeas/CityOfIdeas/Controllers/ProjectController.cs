using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CID.BL;

namespace CityOfIdeas.Controllers
{

    public class ProjectController : Controller
    {
        private IProjectManager mgr;

        public ProjectController()
        {
            mgr = new ProjectManager();

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}