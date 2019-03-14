using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CID.BL.Domain;
using Microsoft.EntityFrameworkCore;

namespace CID.DAL.EF
{
    public class ProjectRepository : IProjectRepository
    {
        private CityOfIdeasDbContext ctx = null;

        public ProjectRepository()
        {
            ctx = new CityOfIdeasDbContext();
        }
        public Project CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public Ideation CreateTicketResponse(Ideation ideation)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(string projectNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ideation> ReadIDeationsOfProject(string projectNumber)
        {
            IEnumerable<Ideation> ideations = ctx.Ideations
                                                      .Where(ideation => ideation.Project.ID == projectNumber)
                                                      .AsEnumerable();

            return ideations;
        }

        public Project ReadProject(string projectNumber)
        {
           
            return ctx.Projects.Find(projectNumber);
        }

        public IEnumerable<Project> ReadProjects()
        {

            return ctx.Projects.Include(t => t.Ideations).AsEnumerable();
        }

        public void UpdateProject(Project ticket)
        {
            throw new NotImplementedException();
        }
    }
}
