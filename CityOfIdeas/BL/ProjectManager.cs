﻿using System;
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
        public Ideation AddIdeation(int projectNumber, string title, string text, ICollection<TagEnum> tags)
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

        public IEnumerable<Ideation> GetIdeations(int projectNumber)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int ticketNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public void RemoveProject(int ticketNumber)
        {
            throw new NotImplementedException();
        }
    }
}
