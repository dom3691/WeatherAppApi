using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.DTOs
{
    public class TaskListDTO : CreateTaskDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysOverDue { get; set; }
        public int DaysLate { get; set; }
    }
}
