using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Models;

namespace TaskManager.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskList> AddTaskAsync(TaskList data);
        Task<bool> DeleteAsync(string Id);
        Task<IQueryable<TaskList>> GetAllTasksAsync();
        Task<TaskList> GetTaskByIdAsync(string Id);
    }
}
