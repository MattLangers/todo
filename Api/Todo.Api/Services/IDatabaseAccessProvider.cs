﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Services
{
    using Models.Database;
    using Models.InputModels;

    public interface IDatabaseAccessProvider
    {
        Task<IList<Task>> GetTasks();

        Task<Task> GetTask(int id);

        Task<Task> PersistTask(TaskInputModel task);
    }
}
