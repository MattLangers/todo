using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Services
{
    using Models.Database;

    public interface IDatabaseAccessProvider
    {
        IEnumerable<Task> GetTasks();
    }
}
