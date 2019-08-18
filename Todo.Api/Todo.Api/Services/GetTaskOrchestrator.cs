namespace Todo.Api.Services
{
    using System.Collections.Generic;
    using Models;
    using Models.OutputModels;

    public class GetTaskOrchestrator : IGetTaskOrchestrator
    {
        private readonly ITaskFactory taskFactory;
        private readonly IDatabaseAccessProvider databaseAccessProvider;

        public GetTaskOrchestrator(
            ITaskFactory taskFactory,
            IDatabaseAccessProvider databaseAccessProvider)
        {
            this.taskFactory = taskFactory;
            this.databaseAccessProvider = databaseAccessProvider;
        }

        public IEnumerable<Task> GetTasks()
        {
            return this.taskFactory.Create(this.databaseAccessProvider.GetTasks());
        }
    }
}
