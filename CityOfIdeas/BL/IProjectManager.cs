using CID.BL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CID.BL
{
    public interface IProjectManager 
    {
        IEnumerable<Project> GetProjects();
<<<<<<< HEAD
        Project GetProject(string projectNumber);
        Project AddProject(string titel, string preface, string text);
        void ChangeProject(Project ticket);
        void RemoveProject(string projectNumber);
=======
        Project GetProject(string ticketNumber);
        Project AddProject(string titel, string preface, string text);
        void ChangeProject(Project ticket);
        void RemoveProject(string ticketNumber);
>>>>>>> 0e761e92ff1d215a4b66be536b211516dfec0d90

        IEnumerable<Ideation> GetIdeations(string projectNumber);
        Ideation AddIdeation(string projectNumber, string title, string text, ICollection<TagEnum> tags);
    }
}
