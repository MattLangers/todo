namespace Todo.Api.Services
{
    using Models;

    public interface ITaskFactory
    {
        Task Create(Models.Database.Task task);
    }
}
