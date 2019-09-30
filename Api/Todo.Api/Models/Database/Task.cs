namespace Todo.Api.Models.Database
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Label { get; set; }

        public bool IsCompleted { get; set; } = false;

        public bool IsDeleted { get; set; } = false;
    }
}
