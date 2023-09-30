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