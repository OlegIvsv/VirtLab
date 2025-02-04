﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetAllProjects(bool trackChanges);
        Project GetProject(Guid projectId, bool trackChanges);
    }
}
