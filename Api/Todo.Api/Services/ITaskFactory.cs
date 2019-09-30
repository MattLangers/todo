namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Models.OutputModels;
    using Task = Database.Models.Task;

    public interface ITaskFactory
    {
        IList<TaskOutputModel> Create(IList<Task> tasks);

        TaskOutputModel Create(Task task);
    }
}
