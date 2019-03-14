using System;
using System.Collections.Generic;
using System.Text;
using CID.BL.Domain;
using CID.DAL;
using CID.DAL.EF;

namespace CID.BL
{
   public class ProjectManager : IProjectManager
    {
        private readonly IProjectRepository repo;

        public ProjectManager()
        {
            //repo = new TicketRepositoryHC();
            repo = new ProjectRepository();
        }
        public Ideation AddIdeation(string projectNumber, string title, string text, ICollection<TagEnum> tags)
        {
            throw new NotImplementedException();
        }

        public Project AddProject(string titel, string preface, string text)
        {
            throw new NotImplementedException();
        }

        public void ChangeProject(Project ticket)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ideation> GetIdeations(string projectNumber)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public Project GetProject(string projectNumber)
=======
        public Project GetProject(string ticketNumber)
>>>>>>> 0e761e92ff1d215a4b66be536b211516dfec0d90
        {
            return repo.ReadProject(projectNumber);
        }

        public IEnumerable<Project> GetProjects()
        {
            return repo.ReadProjects();
        }

<<<<<<< HEAD
        public void RemoveProject(string projectNumber)
=======
        public void RemoveProject(string ticketNumber)
>>>>>>> 0e761e92ff1d215a4b66be536b211516dfec0d90
        {
            throw new NotImplementedException();
        }
    }
}
