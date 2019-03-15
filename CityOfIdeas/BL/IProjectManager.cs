using CID.BL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CID.BL
{
    public interface IProjectManager 
    {
        IEnumerable<Project> GetProjects();
        Project GetProject(string projectNumber);
        Project GetProjectWithIdeations(string projectNumber);
        Project AddProject(string titel, string preface, string text);

        void ChangeProject(Project ticket);
        void RemoveProject(string projectNumber);
        void Stem(string projectNumber);

        IEnumerable<Ideation> GetIdeations(string projectNumber);
        Ideation AddIdeation(string projectNumber, string title, string text, ICollection<TagEnum> tags);
    }
}
