using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Models
{
    public class TaskList
    {
        public string TaskID { get; set; } = string.Empty;
        public string TaskName { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public int AllottedTimeInDays { get; set; }
        public int ElapsedTimeInDays { get; set; }
        public bool TaskStatus { get; set; }    
    }
}
