namespace Todo.Api.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Models.OutputModels;
    using Task = Database.Models.Task;

    public class TaskFactory : ITaskFactory
    {
        public IList<TaskOutputModel> Create(IList<Task> tasks)
        {
            return tasks.Select(task => new TaskOutputModel() { Id = task.Id, IsComplete = task.IsCompleted, IsDeleted = task.IsCompleted, Title = task.Label }).ToList();
        }

        public TaskOutputModel Create(Task task)
        {
            return new TaskOutputModel() { Id = task.Id, IsComplete = task.IsCompleted, IsDeleted = task.IsDeleted };
        }
    }
}
