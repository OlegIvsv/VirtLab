﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProjectService
    {
        IEnumerable<Project> GetAllProjects(bool trackChanges);
        Project GetProject(Guid projectId, bool trackChanges);
    }
}
