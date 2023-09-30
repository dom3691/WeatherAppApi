using System.ComponentModel.DataAnnotations;

namespace TaskManager.Core.DTO
{
    public class CreateTaskDTO
    {
        [Required]
        public string TaskName { get; set; } = string.Empty;
        [Required]
        public string TaskDescription { get; set; } = string.Empty;
        [Required]
        public int AllottedTimeInDays { get; set; }
        [Required]
        public int ElapsedTimeInDays { get; set; }
        public bool TaskStatus { get; set; }
    }
}
