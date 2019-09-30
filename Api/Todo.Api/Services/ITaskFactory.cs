namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Models.OutputModels;

    public interface ITaskFactory
    {
        IList<TaskOutputModel> Create(IList<Models.Database.Task> tasks);

        TaskOutputModel Create(Models.Database.Task task);
    }
}
