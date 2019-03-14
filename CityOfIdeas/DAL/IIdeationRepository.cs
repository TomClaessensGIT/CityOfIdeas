using System;
using System.Collections.Generic;
using CID.BL.Domain;
using System.Text;

namespace CID.DAL
{
    public interface IProjectRepository
    {
        #region Project
        IEnumerable<Project> ReadProjects();
        // CRUD Project
        Project CreateProject(Project project);
        Project ReadProject(int projectNumber);
        void UpdateProject(Project ticket);
        void DeleteProject(int projectNumber);
        #endregion

        #region ProjectIdeation
        IEnumerable<Ideation> ReadIDeationsOfProject(int projectNumber);
        //// CRUD Ideation
        Ideation CreateTicketResponse(Ideation ideation);
        #endregion
    }
}
