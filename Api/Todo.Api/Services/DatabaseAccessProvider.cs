using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Services
{
    using Database;
    using Database.Models;
    using Models.InputModels;

    public class DatabaseAccessProvider : IDatabaseAccessProvider
    {
        public async Task<IList<Task>> GetTasks()
        {
            throw new NotImplementedException();
        }

        public async Task<Task> GetTask(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Task> PersistTask(TaskInputModel task)
        {
            throw new NotImplementedException();
        }
    }
}
