namespace Todo.Api.Database
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
