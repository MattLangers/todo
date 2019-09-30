namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Models.InputModels;
    using Models.OutputModels;

    public interface ITasksOrchestrator
    {
        Task<IList<TaskOutputModel>> GetTasks();

        Task<TaskOutputModel> GetTask(int id);

        Task<TaskOutputModel> PersistTask(TaskInputModel task);

    }
}
