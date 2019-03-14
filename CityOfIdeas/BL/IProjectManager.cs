using CID.BL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CID.BL
{
    public interface IProjectManager 
    {
        IEnumerable<Project> GetProjects();
        Project GetProject(string ticketNumber);
        Project AddProject(string titel, string preface, string text);
        void ChangeProject(Project ticket);
        void RemoveProject(string ticketNumber);

        IEnumerable<Ideation> GetIdeations(string projectNumber);
        Ideation AddIdeation(string projectNumber, string title, string text, ICollection<TagEnum> tags);
    }
}
