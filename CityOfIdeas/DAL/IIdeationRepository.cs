﻿using System;
using System.Collections.Generic;
using CID.BL.Domain;
using System.Text;

namespace CID.DAL
{
    public interface IIdeationRepository
    {
        #region Ideation
        IEnumerable<Ideation> ReadProjects();
        // CRUD Ideation
        Project CreateIdeation(Ideation ideation);
        Project ReadIdeation(string projectNumber);
        void UpdateIdeation(Ideation ideation);
        void DeleteIdeation(string projectNumber);
        #endregion

    }
}