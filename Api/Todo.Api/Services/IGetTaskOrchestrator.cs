namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using Models;
    using Models.OutputModels;

    public interface IGetTaskOrchestrator
    {
        IEnumerable<Task> GetTasks();
    }
}
