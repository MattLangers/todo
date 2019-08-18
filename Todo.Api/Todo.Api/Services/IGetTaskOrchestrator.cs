namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using Models;

    public interface IGetTaskOrchestrator
    {
        IEnumerable<Task> GetTasks();
    }
}
