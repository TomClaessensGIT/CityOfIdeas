using CID.BL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CID.BL
{
    public interface IProjectManager 
    {
        IEnumerable<Project> GetProjects();
        Project GetProject(int ticketNumber);
        Project AddProject(string titel, string preface, string text);
        void ChangeProject(Project ticket);
        void RemoveProject(int ticketNumber);

        IEnumerable<Ideation> GetIdeations(int projectNumber);
        Ideation AddIdeation(int projectNumber, string title, string text, ICollection<TagEnum> tags);
    }
}
