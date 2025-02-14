﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zhengwei.Project.Api.Applications.Queries
{
   public interface IProjectQueries
    {
        Task<dynamic> GetProjectByUserId(int userId);
        Task<dynamic> GetProjectDetail(int projectId);
    }
}
