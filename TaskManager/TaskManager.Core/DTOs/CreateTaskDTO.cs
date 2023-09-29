using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.DTOs
{
    public class CreateTaskDTO
    {
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
