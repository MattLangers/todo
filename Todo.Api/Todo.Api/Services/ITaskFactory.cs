namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using Models;

    public interface ITaskFactory
    {
        IEnumerable<Task> Create(IEnumerable<Models.Database.Task> task);
    }
}
