namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Models.InputModels;
    using Models.OutputModels;

    public class TasksOrchestrator : ITasksOrchestrator
    {
        private readonly ITaskFactory taskFactory;
        private readonly IDatabaseAccessProvider databaseAccessProvider;

        public TasksOrchestrator(
            ITaskFactory taskFactory,
            IDatabaseAccessProvider databaseAccessProvider)
        {
            this.taskFactory = taskFactory;
            this.databaseAccessProvider = databaseAccessProvider;
        }

        public async Task<IList<TaskOutputModel>> GetTasks()
        {
            return this.taskFactory.Create(await this.databaseAccessProvider.GetTasks());
        }

        public async Task<TaskOutputModel> GetTask(int id)
        {
            return this.taskFactory.Create(await this.databaseAccessProvider.GetTask(id));
        }

        public async Task<TaskOutputModel> PersistTask(TaskInputModel task)
        {
            return this.taskFactory.Create(await this.databaseAccessProvider.PersistTask(task));
        }
    }
}
