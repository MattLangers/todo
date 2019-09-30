namespace Todo.Api.Models.OutputModels
{
    public class TaskOutputModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsComplete { get; set; }

        public bool IsDeleted { get; set; }
    }
}
