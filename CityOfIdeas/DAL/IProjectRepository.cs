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
            Project ReadProject(string projectNumber);
        Project ReadProjectWithIdeations(string projectNumber);
            void UpdateProject(Project ticket);
            void DeleteProject(string projectNumber);
            #endregion

            #region ProjectIdeation
            IEnumerable<Ideation> ReadIDeationsOfProject(string projectNumber);
            //// CRUD Ideation
            Ideation CreateTicketResponse(Ideation ideation);
            #endregion
        }
 }
