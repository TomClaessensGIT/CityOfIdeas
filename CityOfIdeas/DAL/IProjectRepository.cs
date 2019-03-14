using System;
using System.Collections.Generic;
using CID.BL.Domain;
using System.Text;

namespace CID.DAL
{
    public interface IProjectRepository
    {
<<<<<<< HEAD

            #region Project
            IEnumerable<Project> ReadProjects();
            // CRUD Project
            Project CreateProject(Project project);
            Project ReadProject(string projectNumber);
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
=======
        #region Project
        IEnumerable<Project> ReadProjects();
        // CRUD Project
        Project CreateProject(Project project);
        Project ReadProject(string projectNumber);
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
>>>>>>> 0e761e92ff1d215a4b66be536b211516dfec0d90

