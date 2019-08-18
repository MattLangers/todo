namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using Models;
    using Models.OutputModels;

    public interface ITaskFactory
    {
        IEnumerable<Task> Create(IEnumerable<Models.Database.Task> task);
    }
}
