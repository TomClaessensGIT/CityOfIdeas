using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CID.BL;
using CID.BL.Domain;

namespace CityOfIdeas.Controllers
{

    public class ProjectController : Controller
    {
        private IProjectManager mgr;

        public ProjectController()
        {
            mgr = new ProjectManager();

        }

        public IActionResult Index(string id)
        {
            Project project = mgr.GetProjectWithIdeations(id);
            return View(project);
        }

        public IActionResult LoadComments(string id)
        {
            
            return View();
        }

        public IActionResult Stem(string id)
        {
            mgr.Stem(id);
            return RedirectToAction("Index", "Project", new { id = id });
        }

    }
}